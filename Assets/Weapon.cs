using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject Lightning;
    public bool shooting = false;

    // Update is called once per frame
    void Start()
    {
        Debug.Log("your code started");
    }
    void Update()
    {
      if (Input.GetButtonDown("Fire1"))
      {
          shooting = true;
          Shoot();
          Debug.Log("pew pew pew");
      }

      if (Input.GetKeyUp("Fire1"))
      {
          shooting = false;
      }
    }

    void Shoot()
    {
        while (shooting)
        Instantiate(Lightning, firePoint.position, firePoint.rotation);
    } 
}
