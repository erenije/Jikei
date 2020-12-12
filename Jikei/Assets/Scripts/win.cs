using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject winMenuUI;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player"){
            if (GameIsPaused)
            {
                Nextlvl();
             }
            else
            {
                Pause();
            }
        }
    }
    public void Nextlvl()
    {
        winMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(2);
    }
    public void LoadMenu()
    {
        Debug.Log("Load");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main menu");
    }
    void Pause()
    {
        winMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
