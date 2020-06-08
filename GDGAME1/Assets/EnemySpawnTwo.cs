using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnTwo : MonoBehaviour
{
    public bool Spawn;
    public Transform[] spawnPos;
    public GameObject[] FlyingEnemies;
    private int RandSpawn;
    private int RandEnemy;


    // Use this for initialization
    void Start()
    {
        Spawn = false;
        InvokeRepeating("SpawnEnemies", 0f, 2.5f);

    }

    private void Update()
    {
        if (FindObjectOfType<TopDownMove>().isgameOver == true)
        {
            Spawn = false;
        }
        if(FindObjectOfType<Timer>().phase2 == true)
        {
            Spawn = true;
        }
       
     

    }

    void SpawnEnemies()
    {
        if (Spawn==true)
        {
            RandSpawn = Random.Range(0, spawnPos.Length);
            RandEnemy = Random.Range(0, FlyingEnemies.Length);
            Instantiate(FlyingEnemies[RandEnemy], spawnPos[RandSpawn].position,
                Quaternion.identity);
        }
    }
}

