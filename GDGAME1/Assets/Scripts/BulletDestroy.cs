using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    // public GameObject Explode;



    // Start is called before the first frame update
    void Start()
    {

        Destroy(this.gameObject, 0.5f);

    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<TopDownMove>().Blue == true)
        {
            BlueBullet();
        }
        if (FindObjectOfType<TopDownMove>().Green == true)
        {
            GreenBullet();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            Destroy(this.gameObject);
        }
    }

    public void BlueBullet()
    { 
      this.gameObject.tag = "BlueBullet";
      this.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
    }
    public void GreenBullet()
    {
        this.gameObject.tag = "GreenBullet";
        this.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
    }

    //  private void OnCollisionEnter2D(Collision2D other)
    //  {
    //      //Instantiate(particle effect ting, transform.position, Quaternion.identity);
    //   /   
    //     if (other.gameObject.tag == "Enemy")
    //     {
    //

    //          Destroy(this.gameObject);
    //    }
    // }






}
