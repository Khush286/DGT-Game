using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public static bool GameIsPaused = false;
    //public string theCurrentScene;

    void Start()
    {
        Resume();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && (SceneManager.GetActiveScene().name != "MainMenu"))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("Loading Menu...");
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Debug.Log("Game was quit");
        Application.Quit();
    }
}
