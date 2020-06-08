using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public bool Spawn;
    public Transform[] spawnPos;
    public GameObject[] FlyingEnemies;
    private int RandSpawn;
    private int RandEnemy;
   

    // Use this for initialization
    void Start()
    {
        Spawn = true;
        InvokeRepeating("SpawnEnemies", 0f, 3f);

    }

    private void Update()
    {
     //  if (FindObjectOfType<TopDownMove>().isgameOver == true)
    //  // {
           //     Spawn = false;
      // }
    }

    void SpawnEnemies()
    {
        if (Spawn)
        {
            RandSpawn = Random.Range(0, spawnPos.Length);
            RandEnemy = Random.Range(0, FlyingEnemies.Length);
            Instantiate(FlyingEnemies[RandEnemy], spawnPos[RandSpawn].position,
                Quaternion.identity);
        }
    }
}
