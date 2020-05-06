using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{

    public static bool Pause = false;
    public GameObject PauseObj;
  

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Pause)
            {
                PlayGame();
            }
            else
            {
                Paused();
            }
        }
    }

    public void PlayGame()
    {
        PauseObj.SetActive(false);
        Time.timeScale = 1f;
        Pause = false;
    }

    public void Paused()
    {
        PauseObj.SetActive(true);
        Time.timeScale = 0f;
        Pause = true;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Tut()
    {
        SceneManager.LoadScene("HowTo");
    }
    public void Level()
    {
        SceneManager.LoadScene("TopDown");
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}