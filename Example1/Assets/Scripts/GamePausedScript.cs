using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePausedScript : MonoBehaviour
{
    public GameObject pausedPanel;
    public bool onGamePaused;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(onGamePaused)
            {
                pausedPanel.SetActive(false);
                onGamePaused = false;
                Time.timeScale = 1;
            }
            else
            {
                pausedPanel.SetActive(true);
                onGamePaused = true;
                Time.timeScale = 0;
            }
        }
    }
}
