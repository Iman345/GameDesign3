using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private int lives;
    public float ClockValue = 0f;
    public Text PlayerLivesTxt;
    //private int SecondsForRespawn;
    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
        PlayerLivesTxt.text =" "+ lives;
       // SecondsForRespawn = 3;
    }

 

   
    // Update is called once per frame
    void Update()
    {
        if (Time.time > ClockValue + 3 && gameObject.tag != "Player")
        {
            gameObject.tag = "Player";
        }

        if (lives <= 0)
        {
            gameObject.SetActive(false);
            GameController.Controller.PlayerDied();
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            lives--;
            Vulnerable();
            
            
        }
    }
   


      

   public void Vulnerable()
    {
        
        gameObject.tag = "Invulnerable";

        
        ClockValue = Time.time;

    }
  

}


