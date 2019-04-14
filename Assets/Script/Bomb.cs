using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bomb : MonoBehaviour
{
    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton Down("Fire2"))
        {
            blowUp();
            Debug.Log("hey that's pretty good");
        }

        void blowUp()
        {
           // var enemies = GameObject[] = GameObject.FindGameObjectsWithTag("Enemy");
           enemies = GameObject.FindGameObjectsWithTag("Enemy");
           for (int i = 0 ;i < enemies.Length; i++)
           {
               Debug.Log("somehow we got to this for loop god help us " + i + " times");
           }
        }
    }
}
