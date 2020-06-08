using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowball : MonoBehaviour
{
    public int Bossdamage;
    public float Bulletspeed;
    public GameObject explode;

    public AudioSource Dead;

    private void Start()
    {
        Destroy(this.gameObject, 0.5f);

    }

    private void Update()
    {
        transform.Translate(Vector2.up * Bulletspeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Boss")
        {
            Dead.Play();
        
          // Instantiate(explode, transform.position, Quaternion.identity);
           
            Destroy(gameObject);
        }
    }
}
