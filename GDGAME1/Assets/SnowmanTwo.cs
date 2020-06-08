using System.Collections;
using UnityEngine;

public class SnowmanTwo : MonoBehaviour
{

    public GameObject GOobj;
    public GameObject WinObj;

    // Start is called before the first frame update
    void Start()
    {

        
    }
   

    // Update is called once per frame
    void Update()
    {
       

        if (FindObjectOfType<Boss>().Health<= 0)
        {
            StartCoroutine("Winner");
        }
        if (FindObjectOfType<Snowman>().GameOver == true)
        {
            StartCoroutine("GameO");
        }
       
    }
   
    IEnumerator GameO()
    {
        yield return new WaitForSeconds(2f);
        GOobj.SetActive(true);
    }
    IEnumerator Winner()
    {
        yield return new WaitForSeconds(2f);
       WinObj.SetActive(true);
    }



}


