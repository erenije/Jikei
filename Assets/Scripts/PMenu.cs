using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject settingsMenu;
    private static bool settings2=false;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&& (settings2 == false))
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
        GameIsPaused = false;
    }
    public void LoadMenu()
    {
        Debug.Log("Load");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main menu");
    }
    public void Settings()
    {
        settingsMenu.SetActive(true);
        pauseMenuUI.SetActive(false);
        settings2 = true;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void back()
    {
        settingsMenu.SetActive(false);
        pauseMenuUI.SetActive(true);
        settings2 =false;
    }
}
