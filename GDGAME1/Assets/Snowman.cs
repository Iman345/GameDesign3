using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowman : MonoBehaviour
{
   

    private Animator anim;
    private Rigidbody2D rigb;
    public int Phealth;
    public float Playerspeed;
    private Vector2 moveForce;
    public bool left;
    public bool right;
    //public AudioSource PlayerDead;
    public bool GameOver;
    public AudioSource DeadSound;
    public bool playerDead;

   


    private void Start()
    {
        Phealth = 1;
        anim = GetComponent<Animator>();
        rigb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), 0);

        moveForce = moveInput.normalized * Playerspeed;

        if (moveInput != Vector2.zero)
        {
            anim.SetBool("Running", true);
        }
        else
        {
            anim.SetBool("Running", false);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            transform.eulerAngles = new Vector2(0, 180);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles = new Vector2(0, 0);
          
        }
       

        if (Phealth <= 0)
        {
            anim.SetBool("Dead", true);
            Playerspeed = 0;
            playerDead = true;
            GameOver = true;
        }
    }

    private void FixedUpdate()
    {
        rigb.MovePosition(rigb.position + moveForce * Time.fixedDeltaTime);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "PortalRight")
        {

            left = false;
            right = true;

        }
        if (collision.gameObject.tag == "PortalLeft")
        {
            left = true;
            right = false;
        }

        if (collision.gameObject.tag == "Enemy")
        {

            Phealth--;
            DeadSound.Play();
          

        }
        if (collision.gameObject.tag == "Boss")
        {

            Phealth--;
            DeadSound.Play();



        }

    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Boss")
        {

            Phealth--;


        }
    }

}

