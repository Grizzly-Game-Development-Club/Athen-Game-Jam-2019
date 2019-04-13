using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public int waypointId;
    public GameObject enemyPrefab;
    public List<GameObject> waypointList;

    public GameObject childMarker;


    // Start is called before the first frame update
    void Start()
    {
        waypointList = new List<GameObject>();

        foreach (Transform marker in childMarker.transform)
        {
            waypointList.Add(marker.gameObject);
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetNextMarker(GameObject currentMarker)
    {
        int index = waypointList.IndexOf(currentMarker);
        if (waypointList[index + 1] != null)
        {
            return waypointList[index + 1];
        }
        else
        {
            return null;
        }

    }
}
