using UnityEngine;

public class enemyDamage : MonoBehaviour
{
    public liveManager liveManager;

    void Start()
    {
        liveManager = GameObject.FindGameObjectWithTag("liveManager").GetComponent<liveManager>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            liveManager.removeLive();
        }
    }
}
