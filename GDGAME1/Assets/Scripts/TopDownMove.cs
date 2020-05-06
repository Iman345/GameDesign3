using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopDownMove : MonoBehaviour
{
    private Rigidbody2D rigb;
    private Vector2 PlayerMove;
    public float PlayerSpeed;
    public Camera Mouseclick;
    private Vector2 mDirection;
    private Vector2 mpos;
    private float mAngle;
    public int lives;
    public Text Livestxt;
    private bool PlayerHit;
    public bool isgameOver;
    public GameObject Over;
    public int score;
    public AudioSource DeadSound;
    public AudioSource Ouch;
    public string PlayerColour;
    // public GameObject Points;
    public Text Scoretxt;
    public bool Blue;
    public bool Green;

    // Start is called before the first frame update
    void Start()
    {
       
        lives = 3;
        rigb = GetComponent<Rigidbody2D>();
        Livestxt.text = " "+lives;
        Over.SetActive(false);
        score = 0;
        Scoretxt.text = "" + score;
        PlayerColour = "White";
        Green = false;
        Blue = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        //PlayerMove.x = Input.GetAxisRaw("Horizontal");
        mpos = Mouseclick.ScreenToWorldPoint(Input.mousePosition);



        if (lives <= 0)
        {
            Livestxt.text = "0";
            DeadSound.Play();
            isgameOver = true;
            // Over.SetActive(true);
            StartCoroutine("PlayerDead");
           
            
        }

        if (PlayerHit == true)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            PlayerColour = "Red";
            StartCoroutine(NormalColour());
        }

        if (Blue == true)
        {
            BluePhase();
        }
        if(Green == true)
        {
            GreenPhase();
        }
         

    }
    private void FixedUpdate()
    {
       // rigb.MovePosition(rigb.position + PlayerMove * PlayerSpeed * Time.fixedDeltaTime);
        mDirection = mpos - rigb.position;
        mAngle = Mathf.Atan2(mDirection.y, mDirection.x)*Mathf.Rad2Deg-90f;
        rigb.rotation = mAngle;

        
    }

    public void EnemyHit()
    {
        score = score+ 10;
        Scoretxt.text = "" + score;
    }

   // private void OnCollisionEnter2D(Collision2D other)
   // {
      //  if (other.gameObject.tag == "Enemy")
   //     {
    //        lives--;
   //         Debug.Log(lives);
     //   }
  //  }

    //private void OnCollisionEnter2D(Collision2D other)
   // {
    ///    if (other.gameObject.tag == "Enemy")
   //     {
    //        lives--;
    //        Debug.Log(lives);
   //     }
   // }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag =="Enemy")
        {
            lives--;
            Livestxt.text = " " + lives;
            Debug.Log("Hit");

            PlayerHit = true;
            Ouch.Play();
}
    }

    IEnumerator NormalColour()
    {
        yield return new WaitForSeconds(0.5f);
        GetComponent<SpriteRenderer>().color = Color.white;
        PlayerColour = "White";
        PlayerHit= false;
    }

    public void Hit()
    {
        lives--;

    }

    IEnumerator PlayerDead()
    {
        yield return new WaitForSeconds(0.3f);
        Over.SetActive(true);
        
    }

    

   public void BluePhase()
  {
   GetComponent<SpriteRenderer>().color = Color.blue;
       this.gameObject.tag = "BluePlayer";
    
      PlayerColour = "Blue";
        Green = false;
   }
    public void GreenPhase()
    {
        GetComponent<SpriteRenderer>().color = Color.green;
        this.gameObject.tag = "GreenPlayer";
      
        PlayerColour = "Green";
        Blue = false;
    }

}
