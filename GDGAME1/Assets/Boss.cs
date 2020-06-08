using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public float BossSpeed;
    public float StopHere;
    public float MoveAway;
    public Transform player;
 private float ShotTimer;
    public float StartShots;
    public GameObject Bullet;
    public int Health;
    private Animator anim;

    public Slider healthBar;
    public AudioSource BossDead;
    public AudioSource BulletHit;




    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
        Health = 10;
        healthBar.value = Health;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = Health;
       
        if (Vector2.Distance(transform.position, player.position) > StopHere)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, BossSpeed * Time.deltaTime);
        }
        else if
   
            (Vector2.Distance(transform.position, player.position) < StopHere && Vector2.Distance(transform.position, player.position) > MoveAway)
        {
            transform.position = this.transform.position;

        }

        if (FindObjectOfType<Snowman>().playerDead == true)
        {
            StartShots = 100;
            BossSpeed = 0;
        }
            if (ShotTimer <= 0)
        {
            BulletHit.Play();
            Instantiate(Bullet, transform.position, Quaternion.identity);
            ShotTimer = StartShots;


        }
        else
        {
            ShotTimer -= Time.deltaTime;
        }

        if (FindObjectOfType<Snowman>().left == true)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
        if (FindObjectOfType<Snowman>().right == true )
        {
            transform.eulerAngles = new Vector2(0, 0);
        }

        if(Health <= 0)
        {
            anim.SetBool("Dead", true);
            StartShots = 100;
            BossSpeed = 0;
        }



    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Health--;
           
            Debug.Log("hit trig");
        }
    }
    
   



}
