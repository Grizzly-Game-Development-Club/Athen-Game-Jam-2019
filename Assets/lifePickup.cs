using UnityEngine;

public class lifePickup : MonoBehaviour
{
    public liveManager liveManager;

    private void Start()
    {
        liveManager = GameObject.FindGameObjectWithTag("liveManager").GetComponent<liveManager>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            liveManager.addLive();
            Destroy(this.gameObject);
        }
    }
}