using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_MarkerType {None, Straight, Stop}

public class Marker : MonoBehaviour
{
    public E_MarkerType markerType;
    public float WaitTime;

    IEnumerator Move(GameObject enemy)
    {
        yield return new WaitForSeconds(WaitTime);
        GameObject nextWaypoint = GetComponentInParent<Waypoint>().GetNextMarker(this.gameObject, enemy.gameObject);
        if (nextWaypoint != null)
        {
            enemy.gameObject.GetComponent<EnemyController>().Move(nextWaypoint);
        }
        else
        {
            enemy.gameObject.GetComponent<EnemyController>().Despawn();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy") {
            
            int waypointId = GetComponentInParent<Waypoint>().waypointId;
            int enemyWaypointID = other.GetComponent<EnemyController>().enemyWaypointID;


            if (waypointId == enemyWaypointID)
            {
                switch (markerType)
                {
                    case E_MarkerType.Straight:
                        other.GetComponent<EnemyController>().Fire();
                        break;
                    case E_MarkerType.None:
                       
                        break;
                    case E_MarkerType.Stop:
                        other.GetComponent<EnemyController>().StopFire();
                        break;
                }

                StartCoroutine(Move(other.gameObject));              
                
            }
        }
    
    } 
}
