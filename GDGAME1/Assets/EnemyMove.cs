using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Rigidbody2D rigb;
   public GameObject Player;
    public float EnemySpeed;
   private Vector3 direction;
    public GameObject Explode;
  

    // Use this for initialization
    void Start()
    {
        rigb = GetComponent<Rigidbody2D>();
       // Player = GameObject.Find("Player");

        EnemySpeed = Random.Range(1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemies();
    }

    

    void MoveEnemies()
    {
        if (Player != null)
        {
            direction = (Player.transform.position - transform.position).normalized;
            rigb.velocity = new Vector2(direction.x * EnemySpeed,direction.y * EnemySpeed);
        }
        else {
            rigb.velocity = Vector3.zero;
        }
            
    }

   
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {

            Instantiate(Explode, transform.position, Quaternion.identity);
            Destroy(this.gameObject);

        }
        if (other.gameObject.tag == "Bullet")
        {
           
            Instantiate(Explode, transform.position, Quaternion.identity);
            Destroy(this.gameObject);

        }
    }
}


