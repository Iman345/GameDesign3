using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanOne : MonoBehaviour
{
    public GameObject Portal;
    public GameObject GOobj;

    // Start is called before the first frame update
    void Start()
    {
        Portal.SetActive(false);
        StartCoroutine("FirstWave");
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<Snowman>().GameOver == true)
        {
            
            FindObjectOfType<EnemySpawn>().Spawn = false;
            StartCoroutine("GameO");
        }
    }  
    IEnumerator FirstWave()
    {
        yield return new WaitForSeconds(10f);
        FindObjectOfType<EnemySpawn>().Spawn = false;
        Portal.SetActive(true);
    }
    IEnumerator GameO()
    {
        yield return new WaitForSeconds(2f);
        GOobj.SetActive(true);
    }

}
