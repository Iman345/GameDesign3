using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    public float CircleSpeed;
    private float pause;
    public float Starttime;
    public Transform[] Pos;
    private int randompos;
    public GameObject BlueExplode;
   // public GameObject BlueC;
    // Start is called before the first frame update
    void Start()
    {
        //   BlueC.SetActive(false);
        pause = Starttime;
        randompos = Random.Range(0, Pos.Length);


    }

    // Update is called once per frame
    void Update()
    {

       

    }



    private void OnTriggerEnter2D(Collider2D collision)
   {
       if(collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "GreenBullet")
       {
          Instantiate(BlueExplode, transform.position, Quaternion.identity);
            FindObjectOfType<TopDownMove>().Blue = true;
            FindObjectOfType<TopDownMove>().Green = false;
            FindObjectOfType<TopDownMove>().PlayerColour = "Blue";
            // BlueC.SetActive(true);

        }
   }







}
