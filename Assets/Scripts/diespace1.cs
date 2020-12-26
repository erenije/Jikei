using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class diespace1 : MonoBehaviour
{
    public static bool dead = false;
    public static bool GameIsPaused = false;
    public GameObject deadMenuUI;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player"){
            if (GameIsPaused)
            {
                
             }
            else
            {
                Pause();
            }
        }
    }
    public void Restart()
    {
        deadMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
        Collect.TheCherry =0;
        dead=false;
    }
    public void Pause()
    {
        dead=true;
        deadMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        Debug.Log("Load");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    
}
