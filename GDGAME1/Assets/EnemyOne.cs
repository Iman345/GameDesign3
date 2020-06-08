﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOne : MonoBehaviour
{
   
    private Rigidbody2D rigb;
    public GameObject Player;
    private float EnemySpeed;
    public float EnemySpeedRange1, EnemySpeedRange2;
    private Vector3 direction;
    public GameObject Explode;
    public AudioSource EnemyDead;

    //public GameObject Points;
   // public Text Scoretxt;

    //public int score;



    // Use this for initialization
    void Start()
    {
        rigb = GetComponent<Rigidbody2D>();
        // Player = GameObject.Find("Player");

        EnemySpeed = Random.Range(EnemySpeedRange1, EnemySpeedRange2);

      //  score = 0;
    }

    // Update is called once per frame
    void Update()
    {


        MoveEnemies();

     //   if (FindObjectOfType<TopDownMove>().isgameOver == true)
    //    {
        //    Destroy(this.gameObject);
        //    Instantiate(Explode, transform.position, Quaternion.identity);

       // }
    }



    void MoveEnemies()
    {
        if (Player != null)
        {
            direction = (Player.transform.position - transform.position).normalized;
            rigb.velocity = new Vector2(direction.x * EnemySpeed, direction.y * EnemySpeed);
        }
        else
        {
            rigb.velocity = Vector3.zero;
        }

    }




    //  public void OnCollisionEnter2D(Collision2D other)
    // {
    //     if (other.gameObject.tag == "Player")
    //      {
    //          Instantiate(Explode, transform.position, Quaternion.identity);
    //       Destroy(this.gameObject);
    ///
    //      }
    //      if (other.gameObject.tag == "Bullet")
    //      {

    //         
    //         Instantiate(Explode, transform.position, Quaternion.identity);
    //         Destroy(this.gameObject);
    //
    //      }
    //  }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(Explode, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            EnemyDead.Play();

        }

        if (other.gameObject.tag == "Bullet")
        {
            Instantiate(Explode, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            EnemyDead.Play();
        }


    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(Explode, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            EnemyDead.Play();

        }

        if (other.gameObject.tag == "Bullet")
        {
            Instantiate(Explode, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            EnemyDead.Play();

        }
    }



}

    
    

