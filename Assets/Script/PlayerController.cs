using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb2d;
    private Vector2 moveVelocity;
    public int playerHealth;
    //public Transform firePoint
    void Start()
    {
        rb2d = GetComponent <Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
       Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
       moveVelocity = moveInput.normalized * speed;

       if (playerHealth == 0)
       {
           Death();
       }
       /* if (Input.GetKeyDown(KeyCode.F))
       {
           Fire();
       } */
    }
    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + moveVelocity * Time.fixedDeltaTime);
    }

    /* void Fire()
    {
        


    }*/

    void Death()
    {

    }
}
