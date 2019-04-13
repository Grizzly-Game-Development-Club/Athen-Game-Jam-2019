using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Top Collider")
        {
            Destroy(this.gameObject);
        }
    }
}
