using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnThree : MonoBehaviour
{
    public bool Spawn;
    public Transform[] spawnPos;
    public GameObject[] FlyingEnemies;
    private int RandSpawn;
    private int RandEnemy;
    public GameObject BlueCircle;
    public GameObject GreenCircle;
   

    // Use this for initialization
    void Start()
    {
        Spawn = false;
        InvokeRepeating("SpawnEnemies", 0f, 1f);

    }

    private void Update()
    {
        if (FindObjectOfType<TopDownMove>().isgameOver == true)
        {
            Spawn = false;
        }

        if(Spawn == true)
        {
            BlueCircle.SetActive(true);
            GreenCircle.SetActive(true);
        }
    }

    void SpawnEnemies()
    {
        if (Spawn == true)
        {
            RandSpawn = Random.Range(0, spawnPos.Length);
            RandEnemy = Random.Range(0, FlyingEnemies.Length);
            Instantiate(FlyingEnemies[RandEnemy], spawnPos[RandSpawn].position,
                Quaternion.identity);
        }
    }
}

