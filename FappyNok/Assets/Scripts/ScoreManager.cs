using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextGameOver;
    public Text highScoreTextGameOver;
    public int highScore;
    public float scoreAmount;
    public int scoreIncreasedPerSecond;
    

    void Start()
    {
        scoreAmount = 0f;
        scoreIncreasedPerSecond = 1;
        highScore = PlayerPrefs.GetInt("HighScore");
        highScoreTextGameOver.text = highScore.ToString();
    }

    void Update()
    {
        AddScoreTime();
    }

    public void AddScoreTime()
    {
        scoreText.text = "Score: " + (int)scoreAmount;
        scoreAmount += scoreIncreasedPerSecond * Time.deltaTime;
        AddHighScore((int)scoreAmount);
        
        scoreTextGameOver.text = "SCORE: " + (int)scoreAmount;
    }

    public void AddScoreKill()
    {
        scoreAmount += 1;
    }


    public void AddHighScore(int score)
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            highScoreTextGameOver.text = "HIGHSCORE: " + highScore;
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
        scoreAmount = 0;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("HomePage");
    }

}
