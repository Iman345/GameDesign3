using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Controller;
    public Text ScoreTxt;
    public int Score = 0;
    public GameObject GameOver;
    public AudioSource LevelJam;

    // Start is called before the first frame update
    void Awake()
    {
        Controller = this;
      //  GameOver.SetActive(false);
      //  LevelJam.Play();

    }

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayerDied()
    {


       // GameOver.SetActive(true);

       // LevelJam.Stop();

      //   FindObjectOfType<SpawnWaves>().SpawnEnable = false;

    }

  

    public void Scoring()
    {
        Score = Score + 50;
        ScoreTxt.text =" " + Score;
    }



   

    

 

}


