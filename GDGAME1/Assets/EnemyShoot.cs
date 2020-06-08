using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public float BulletSpeed;
    private Transform player;
    private Vector2 BulletPos;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;
        BulletPos = new Vector2(player.position.x, player.position.y);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, BulletPos, BulletSpeed * Time.deltaTime);
        if (transform.position.x == BulletPos.x && transform.position.y == BulletPos.y)
        {
            DestroyBullet();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            DestroyBullet();
        }
    }


   private void DestroyBullet()
    {
        Destroy(this.gameObject);
        
    }
}
