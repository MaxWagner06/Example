using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject opionsPanel;
    public bool onOptionsPanel;

    public bool onCreditsPanel;
    public GameObject creditsPanel;
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
    public void GameQuit()
    {
        Application.Quit();
    }

    public void OptionsPanel()
    {
        if (!onOptionsPanel)
        {
            opionsPanel.SetActive(true);
            onOptionsPanel = true;
        }
        else
        {
            opionsPanel.SetActive(false);
            onOptionsPanel = false;
        }
    }

    public void CreditsPanel()
    {
        if (!onCreditsPanel)
        {
            creditsPanel.SetActive(true);
            onCreditsPanel = true;
        }
        else
        {
            creditsPanel.SetActive(false);
            onCreditsPanel = false;
        }
    }
}