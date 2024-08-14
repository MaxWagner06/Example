using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public float Counter = 60;
    public Text CounterText;

    public int score;
    public Text scoreText;
    public int highScore;
    public Text highScoreText;

    public bool gameOver;
    public GameObject gameOverPanel;
    public Text gameOverScoreText;
    public Text gameOverHighScoreText;



    private void Start()
    {
        score = 0;
        Time.timeScale = 1;
        gameOver = false;
    }
    private void Update()
    {
        //Time
        Counter = Counter - Time.deltaTime;
        CounterText.text = Mathf.RoundToInt(Counter).ToString();

        //Score
        scoreText.text = score.ToString();

        //GameOver
        if (Counter <= 0)
        {
            Counter = 0;
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            gameOverScoreText.text = score.ToString();
            gameOverHighScoreText.text = highScore.ToString();
            gameOver = true;
        }

        //HighScore
        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
        highScore = PlayerPrefs.GetInt("HighScore");

        highScoreText.text = Mathf.RoundToInt(highScore).ToString();

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void BackMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Restart(){
        SceneManager.LoadScene(1);
    }
}
