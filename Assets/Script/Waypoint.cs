using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Waypoint : MonoBehaviour
{
    public int waypointId;
    public GameObject enemyPrefab;
    public float timeToSpawn;
    public float spawnLimit;
    public float timeBetweenSpawn;
    public List<GameObject> markerList;

    public GameObject childMarker;


    // Start is called before the first frame update
    void Start()
    {
        //Create the waypoint List
        markerList = new List<GameObject>();

        //Fill the waypoint list
        foreach (Transform marker in childMarker.transform)
        {
            markerList.Add(marker.gameObject);
        }

        StartCoroutine("Spawn_IE");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        

    }

    IEnumerator Spawn_IE()
    {
        int currentSpawnCount = 0;
        GameObject firstPosition = markerList[0];
        while (currentSpawnCount != spawnLimit) {          
            GameObject enemy = Instantiate(enemyPrefab, firstPosition.transform.position, Quaternion.identity) as GameObject;
            enemy.GetComponent<EnemyController>().enemyWaypointID = this.waypointId;
            currentSpawnCount++;

            yield return new WaitForSeconds(timeBetweenSpawn);
        }
    }

    //Get the next marker
    public GameObject GetNextMarker(GameObject currentMarker)
    {
        int index = markerList.IndexOf(currentMarker);
        if (markerList.Count - 1 > index)
        {
            return markerList[index + 1];
        }
        else
        {
            return null;
        }

    }
}
