using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public bool phase2;
    public GameObject YouWinobj;
    // Start is called before the first frame update
    void Start()
    {
        YouWinobj.SetActive(false);
        StartCoroutine("FirstWave");
        StartCoroutine("SecondWave");

        StartCoroutine("ThirdWave");
        StartCoroutine("Wait");
        StartCoroutine("YouWin");


    }

    // Update is called once per frame
    void Update()
    {
           

      
    }

    IEnumerator FirstWave()
    {
        yield return new WaitForSeconds(10f);
        FindObjectOfType<EnemySpawn>().Spawn = false;
        FindObjectOfType<EnemySpawnTwo>().Spawn = true;
        phase2 = true;
    }

    IEnumerator SecondWave()
    {
        yield return new WaitForSeconds(20f);
       FindObjectOfType<EnemySpawnTwo>().Spawn = false;
        phase2 = false;
        
        
    
    }
    IEnumerator ThirdWave()
    {
        yield return new WaitForSeconds(36f);
        FindObjectOfType<SpawnThree>().Spawn = false;
        

    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(23f);
        
        FindObjectOfType<SpawnThree>().Spawn = true;


    }

    IEnumerator YouWin()
    {
        yield return new WaitForSeconds(93f);

      YouWinobj.SetActive(true);

    }





}
