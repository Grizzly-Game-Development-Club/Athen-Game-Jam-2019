using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        int waypointId = GetComponentInParent<Waypoint>().waypointId;
        int enemyWaypointID = other.GetComponent<EnemyController>().enemyWaypointID;

        
        if (waypointId == enemyWaypointID)
        {
            Debug.Log(other.name);
            GameObject nextWaypoint = GetComponentInParent<Waypoint>().GetNextMarker(this.gameObject);
            if (nextWaypoint != null)
            {
                other.gameObject.GetComponent<EnemyController>().Move(nextWaypoint);
            }
            else
            {
                other.gameObject.GetComponent<EnemyController>().Despawn();
            }
        }
    
    } 
}
