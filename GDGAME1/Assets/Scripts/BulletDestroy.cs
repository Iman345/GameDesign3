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
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
           
            Destroy(this.gameObject);
        }
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
