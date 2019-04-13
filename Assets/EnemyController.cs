using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int enemyWaypointID;
    public int enemyHealth;
    

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

    public void Move(GameObject nextMarker)
    {
  public float speed;
    public GameObject targetObject;
    public Transform myGameObject;
    private float minimumDistance;

    void Update()
    {
        if (Vector3.Distance(myGameObject.transform.position, targetObject.transform.position) >= minimumDistance)
            myGameObject.transform.position =
                Vector3.MoveTowards(myGameObject.transform.position,
                targetObject.transform.position, Time.deltaTime * speed);
    }

}

    public void Despawn()
    {


    }

    public void Destory()
    {


    }

}
