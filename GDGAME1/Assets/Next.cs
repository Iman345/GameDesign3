using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Snowman");
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {


            StartCoroutine("NextLevel");
        }

    }

}
