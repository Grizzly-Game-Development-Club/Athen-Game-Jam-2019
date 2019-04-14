using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Waypoint : MonoBehaviour
{
    
    [Header("Spawner")]
    public int waypointId;
    public float spawnLimit;
    public float timeBetweenSpawn;

    [Header("Enemy Manipulation")]
    public GameObject enemyPrefab;
    public int enemyHealth;
    public int enemySpeed;
    public int enemyScore;

    [Header("Marker")]
    public List<GameObject> markerList;
    public GameObject childMarker;

    [Header("SpawnTime")]
    public int minuteToSpawn;
    public int secondToSpawn;

    [Header("Bullet")]
    public int bulletSpeed;
    public int fireRate;

    public bool isSpawning;

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

        isSpawning = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().seconds == secondToSpawn &&
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().minutes == minuteToSpawn)
        {
            if (!isSpawning) {
                isSpawning = true;
                StartCoroutine("Spawn_IE");            
            }
            
        }
    }

    IEnumerator Spawn_IE()
    {
        int currentSpawnCount = 0;
        GameObject firstPosition = markerList[0];
        while (currentSpawnCount != spawnLimit) {          
            GameObject enemy = Instantiate(enemyPrefab, firstPosition.transform.position, Quaternion.identity) as GameObject;
            enemy.GetComponent<EnemyController>().enemyWaypointID = this.waypointId;
            enemy.GetComponent<EnemyController>().currentIndex = 0;
            enemy.GetComponent<EnemyController>().enemyHealth = enemyHealth;
            enemy.GetComponent<EnemyController>().enemySpeed = enemySpeed;
            enemy.GetComponent<EnemyController>().enemyScore = enemyScore;
            enemy.GetComponent<EnemyController>().bulletSpeed = bulletSpeed;
            enemy.GetComponent<EnemyController>().fireRate = fireRate;
            currentSpawnCount++;

            yield return new WaitForSeconds(timeBetweenSpawn);
        }
    }

    //Get the next marker
    public GameObject GetNextMarker(GameObject currentMarker, GameObject enemy)
    {
        int index = enemy.GetComponent<EnemyController>().currentIndex;
        if (markerList.Count - 1 > index)
        {
            enemy.GetComponent<EnemyController>().currentIndex += 1;
            return markerList[index + 1];
        }
        else
        {
            return null;
        }

    }
}
