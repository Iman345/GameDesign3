using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rigb;
    private Animator anim;
    private SpriteRenderer srend;
    public float speed;
    public float jumpvel;
   

    // Start is called before the first frame update
    void Start()
    {
        rigb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        srend= GetComponent<SpriteRenderer>();
      speed = 2;
        jumpvel = 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            rigb.velocity = new Vector2(speed, rigb.velocity.y);
            anim.Play("run");
            srend.flipX = false;
          
           
           
        }
        else if  (Input.GetKey("left") || Input.GetKey("a"))
            {
                rigb.velocity = new Vector2(-speed, rigb.velocity.y);
                anim.Play("run");
            
                srend.flipX = true;

            }
        else
        {
            anim.Play("Idle");
            rigb.velocity = new Vector2(0, rigb.velocity.y);
        }
          


       
       

        if (Input.GetKey("space") || Input.GetKey("up"))
        {
            rigb.velocity = new Vector2(rigb.velocity.x, jumpvel);
            anim.Play("jump");
        

        }
        else
        {
            anim.Play("Idle");
        }

    }
}
