using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rgb;
    public float PlayerSpeed;
    private Animator Anim;

    public float JumpVel;
    public float Jtime;
    private bool Jump;
    private float Jcounter;
    private float move;
    public Transform playerpos;
    private bool grounded;
    public float checkground;
    public LayerMask Ground;


    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();

    }
    private void Update()
    {
        grounded = Physics2D.OverlapCircle(playerpos.position, checkground, Ground);

      
    
        if ( Input.GetKey(KeyCode.Space) && grounded == true)
        {
            Jump = true;
            rgb.velocity = Vector2.up * JumpVel;
            Jcounter = Jtime;
        }
        if (Input.GetKey(KeyCode.Space) && Jump== true)
        {
            if (Jcounter > 0)
            {
                rgb.velocity = Vector2.up * JumpVel;
                Jcounter -= Time.deltaTime;
            }

            else
            {
                Jump = false;
            }


            if (move < 0)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
            }
            else if (move > 0)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Jump = false;
        }


       
        

       
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        move = Input.GetAxisRaw("Horizontal");
        rgb.velocity = new Vector2(move * PlayerSpeed, rgb.velocity.y);



    }
  
}
