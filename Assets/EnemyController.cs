using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int enemyWaypointID;
    public int enemyHealth;
    public int enemySpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Attack()
    {


    }
    /*
    public void Move(GameObject nextMarker)
    {
   float speed;
     GameObject targetObject;
     Transform myGameObject;
     float minimumDistance;

        if (Vector2.Distance(myGameObject.transform.position, targetObject.transform.position) >= minimumDistance)
            myGameObject.transform.position =
                Vector2.MoveTowards(myGameObject.transform.position,
                targetObject.transform.position, Time.deltaTime * speed);

    }

    public void Despawn()
    {
        Destroy(this.gameObject);


    }*/

    public void Destory()
    {


    }

}
