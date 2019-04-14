using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public string BulletName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (BulletName) {
            case "Player":
                if (collision.tag == "Enemy")
                {
                    collision.GetComponent<EnemyController>().enemyHealth -= 10;
                    Destroy(this.gameObject);
                }
                break;
            case "Enemy":
                if (collision.tag == "Player")
                {
                    GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().removeLive();
                    Destroy(this.gameObject);
                }
                break;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        switch (BulletName)
        {
            case "Player":
                if (other.name == "Top Collider")
                {
                    Destroy(this.gameObject);
                }
                break;
            case "Enemy":
                if (other.name == "Bottom Collider")
                {
                    Destroy(this.gameObject);
                }
                break;

        }
    }
}
