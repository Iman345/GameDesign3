using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    public GameObject Bullet;
    
   
    public Transform fp;
    public float Force;
    public AudioSource ShotSound;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    void Fire()
    {
        ShotSound.Play();
        GameObject FireBullet = Instantiate(Bullet, fp.position, fp.rotation);
        Rigidbody2D rigb = FireBullet.GetComponent<Rigidbody2D>();
        rigb.AddForce(fp.up * Force, ForceMode2D.Impulse);
       
    }


}
