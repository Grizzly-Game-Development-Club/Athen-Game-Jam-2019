using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerController : MonoBehaviour
{
    public int playerHealth;
    public float speed;
    public GameObject bulletPrefab;
    public float bulletSpeed;
    public float fireRate;

    private float nextFire;
    private Rigidbody2D rb2d;
    private Vector2 moveVelocity;

    private AudioSource source;
    public AudioClip shootSound;

    public List<GameObject> fireList;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }

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
        if (Input.GetKey(KeyCode.X))
       {
           Fire();
       }
    }
    void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + moveVelocity * Time.fixedDeltaTime);
    }

    void Fire()
    {
        if (Time.time > nextFire) {
            foreach (GameObject firepoint in fireList)
            {
                GameObject bullet = Instantiate(bulletPrefab) as GameObject;
                bullet.transform.position = firepoint.transform.position;
                bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * bulletSpeed;
                nextFire = Time.time + fireRate;
                GameObject.Find("ShootSoundEffect");
                source.PlayOneShot(shootSound, 1);
            }
        }

    }

    void Death()
    {

    }
}
