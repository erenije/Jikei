using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenuUI;
    public GameObject selectMenuUI;
    void Start()
    {
        mainMenuUI.SetActive(true);
    }
    public void NewGame()
    {
        SceneManager.LoadScene(2);
        Collect.TheCherry = 0;
    }
    public void Selectlvl()
    {
        mainMenuUI.SetActive(false);
        selectMenuUI.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Back()
    {
        selectMenuUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }
    public void Secondlvl()
    {
        SceneManager.LoadScene(1);
        Collect.TheCherry = 0;
    }
}
