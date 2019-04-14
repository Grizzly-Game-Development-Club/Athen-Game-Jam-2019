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

    public GameObject bulletPrefab;
    public List<GameObject> fireList;
    public float bulletSpeed;
    public float fireRate;
    private float nextFire;

    public bool isFiring;
    public Coroutine fire;
    public Coroutine move;

    public bool isBoss;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fire != null)
            isFiring = true;
        else
            isFiring = false;

        if (enemyHealth <= 0)
        {
            Destory();
        }
    }

    public void Fire()
    {
        if (fire == null)
            fire = StartCoroutine("Fire_IE");
    }

    public void StopFire()
    {
        fire = null;
    }

    public IEnumerator Fire_IE()
    {
        while (true) {
            foreach (GameObject firepoint in fireList)
            {
                GameObject bullet = Instantiate(bulletPrefab) as GameObject;
                bullet.transform.position = firepoint.transform.position;
                bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-1, 1), -1) * bulletSpeed;
            }

            yield return new WaitForSeconds(fireRate);
        }
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
        if(isBoss)
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().gameState = E_GameState.Victory;

        GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().score += enemyScore;
        Destroy(this.gameObject);
    }

}
