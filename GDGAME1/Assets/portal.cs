using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{
   
    public Transform MoveHere;
    public bool right;
    public bool left;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player"&& this.gameObject.tag=="PortalRight")
        {
            other.transform.position = new Vector2(MoveHere.position.x, MoveHere.position.y);
            left = false;
            right = true;
        }
        if (other.gameObject.tag == "Player" && this.gameObject.tag == "PortalLeft")
        {
            other.transform.position = new Vector2(MoveHere.position.x, MoveHere.position.y);
            left =true;
            right = false;
        }
    }
}

