using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourchange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (FindObjectOfType<TopDownMove>().Blue == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
        }
        if (FindObjectOfType<TopDownMove>().Green== true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = Color.green;
        }






    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy") { 
            GetComponent<SpriteRenderer>().color = Color.red;
            StartCoroutine(NormalColour());
        }

    }

    IEnumerator NormalColour()
    {
        yield return new WaitForSeconds(0.5f);
        GetComponent<SpriteRenderer>().color = Color.white;
        
    }
}
