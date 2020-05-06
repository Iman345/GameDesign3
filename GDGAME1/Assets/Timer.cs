using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("FirstWave");
        StartCoroutine("SecondWave");

        StartCoroutine("ThirdWave");
        StartCoroutine("Wait");
        

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
    }

    IEnumerator SecondWave()
    {
        yield return new WaitForSeconds(18f);
       FindObjectOfType<EnemySpawnTwo>().Spawn = false;
    
    }
    IEnumerator ThirdWave()
    {
        yield return new WaitForSeconds(30f);
        FindObjectOfType<SpawnThree>().Spawn = false;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(25f);
        
        FindObjectOfType<SpawnThree>().Spawn = true;
    }


}
