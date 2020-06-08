using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShoot : MonoBehaviour
{
   public float moveSpeed = 7f;

    private Rigidbody2D rigb;
    public GameObject explode;
  

    Snowman target;
   private  Vector2 moveDirection;

    // Use this for initialization
    void Start()
    {
        rigb = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Snowman>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rigb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(this.gameObject, 3f);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") {

            Destroy(gameObject);
     
            Instantiate(explode, transform.position, Quaternion.identity);
        }
        if (other.gameObject.tag == "Bullet")
        {

            Destroy(gameObject);

            Instantiate(explode, transform.position, Quaternion.identity);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            Destroy(gameObject);
            Instantiate(explode, transform.position, Quaternion.identity);
        }
    }
}
