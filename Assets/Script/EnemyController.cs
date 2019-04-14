using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int enemyWaypointID;
    public int enemyHealth;
    public int enemySpeed;
    public int enemyScore;
    public int currentIndex;

    public Coroutine move;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth <= 0)
        {
            Destory();
        }
    }


    public void Attack()
    {


    }

    public void Move(GameObject nextMarker)
    {
        if (nextMarker != null)
        {
            if(move != null)
            StopCoroutine(move);

            move = StartCoroutine("Move_IE", nextMarker);
        }
        else
            Despawn();
    }

    IEnumerator Move_IE(GameObject nextMarker)
    {
        Transform currentPosition = this.transform;
        Transform targetPosition = nextMarker.transform;


        while (currentPosition != targetPosition)
        {
            Debug.Log("Test Move");
            Vector2 newPosition = Vector2.MoveTowards(transform.position, nextMarker.transform.position, enemySpeed * Time.deltaTime);
            transform.position = newPosition;
            currentPosition.position = newPosition;
            yield return null;
        }

        
    }

    public void Despawn()
    {
        Destroy(this.gameObject);
    }

    public void Destory()
    {
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().score += enemyScore;
        Destroy(this.gameObject);
    }

}
