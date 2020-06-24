using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // UI for pausing
    public GameObject mainMenuUI; // UI for the main menu
    public GameObject gameOverMenuUI; // UI for the game over screen
    public GameObject settingsUI;
    public static bool GameIsPaused = false;
    public static bool GameIsOver = false;
    public static bool SettingsIsDisplayed = false;
    public static bool CheatsEnabled = false;
void Start()
    {
        settingsUI.SetActive(false);
        SettingsIsDisplayed = false;
        GameIsOver = (false);
        mainMenuUI.SetActive(false);
        gameOverMenuUI.SetActive(false);
        Resume();
        if (SceneManager.GetActiveScene().name == "MainMenu")
        {
            mainMenuUI.SetActive(true);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && (SceneManager.GetActiveScene().name != "MainMenu"))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else if (!GameIsOver)
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

    public void GameOver()
    {
        gameOverMenuUI.SetActive(true);
        GameIsOver = true;
        GameIsPaused = false;
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

    public void StartGame()
    {
        SettingsIsDisplayed = false;
        GameIsPaused = false;
        Player.playerHealth = 3;
        SceneManager.LoadScene("Room0");
    }

    public void EnableCheats()
    {
        if (CheatsEnabled)
        {
            CheatsEnabled = false;
            settingsUI.transform.Find("EnableCheatsButton").transform.Find("Text").GetComponent<Text>().text = "Enable Cheats: OFF";
        }
        else
        {
            CheatsEnabled = true;
            settingsUI.transform.Find("EnableCheatsButton").transform.Find("Text").GetComponent<Text>().text = "Enable Cheats: ON";
        }
    }

    public void DisplaySettings()
    {
        if (CheatsEnabled)
        {
            settingsUI.transform.Find("EnableCheatsButton").transform.Find("Text").GetComponent<Text>().text = "Enable Cheats: ON";
        }
        else
        {
            settingsUI.transform.Find("EnableCheatsButton").transform.Find("Text").GetComponent<Text>().text = "Enable Cheats: OFF";
        }
        if (SettingsIsDisplayed)
        {
            settingsUI.SetActive(false);
            SettingsIsDisplayed = false;
        }
        else
        {
            SettingsIsDisplayed = true;
            settingsUI.SetActive(true);
        }
    }
}
