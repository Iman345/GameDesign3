using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour2 : MonoBehaviour

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

       // transform.position = Vector2.MoveTowards(transform.position, Pos[randompos].position, CircleSpeed * Time.deltaTime);
       // if (Vector2.Distance(transform.position, Pos[randompos].position) < 0.2f)
      //  {
      //    //  if (pause <= 0)
          //  {
          //      randompos = Random.Range(0, Pos.Length);
           //     pause = Starttime;
         //   }
        //    else
        //        pause -= Time.deltaTime;
      //  }

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet" || collision.gameObject.tag == "BlueBullet")
        {
            Instantiate(BlueExplode, transform.position, Quaternion.identity);
            FindObjectOfType<TopDownMove>().Green = true;
            FindObjectOfType<TopDownMove>().Blue = false;
            FindObjectOfType<TopDownMove>().PlayerColour = "Green";
            // BlueC.SetActive(true);

        }
    }

}
