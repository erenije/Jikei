using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public int collcherry;
    public static bool GameIsPaused = false;
    public GameObject winUI;
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.tag == "Player") && (collcherry <= Collect.TheCherry)){
            if (GameIsPaused)
            {
                
            }
            else
            {
                Pause();
            }
        }
    }
    public void Nextlvl()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);

    }
    void Pause()
    {
        winUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = false;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
