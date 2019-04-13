using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 100f;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent <Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
       //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis ("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis ("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

        if (Input.GetKeyDown(KeyCode.UpArrow)){
            rb2d.velocity = new Vector2(0.0f, speed * Time.deltaTime);
            Debug.Log("up was pressed! :D");
        }
        /*if (Input.GetKeyUp(KeyCode.UpArrow)){
            rb2d.velocity = new Vector2(0.0f, 0.0f);
            Debug.Log("right arrow was released ;)");
        }
        */
        if (Input.GetKeyDown(KeyCode.DownArrow)){
            rb2d.velocity = new Vector2(0.0f, -speed * Time.deltaTime);
            Debug.Log("down was pressed! :D");
        }
        /* if (Input.GetKeyUp(KeyCode.DownArrow)){
            rb2d.velocity = new Vector2(0.0f, 0.0f);
            Debug.Log("right arrow was released ;)");
        }*/
        
        if (Input.GetKeyDown(KeyCode.LeftArrow)){
            rb2d.velocity = new Vector2(-speed * Time.deltaTime, 0.0f);
            Debug.Log("left was pressed! :D");
        }
        /* if (Input.GetKeyUp(KeyCode.LeftArrow)){
            rb2d.velocity = new Vector2(0.0f, 0.0f);
            Debug.Log("right arrow was released ;)");
        }
        */
        if (Input.GetKeyDown(KeyCode.RightArrow)){
            rb2d.velocity = new Vector2(speed * Time.deltaTime, 0.0f);
            Debug.Log("right was pressed! :D");
        }
        /* if (Input.GetKeyUp(KeyCode.RightArrow)){
            rb2d.velocity = new Vector2(0.0f, 0.0f);
            Debug.Log("right arrow was released ;)");
        }
        */

        if ((!Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow)) 
        && (!Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.RightArrow))){
            rb2d.velocity = new Vector2(0.0f, 0.0f);
            Debug.Log("nothing is pressed :(");
        }

    }
}
