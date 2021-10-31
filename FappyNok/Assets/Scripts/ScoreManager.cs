using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public int highScore;
    public float scoreAmount;
    public int scoreIncreasedPerSecond;

    void Start()
    {
        scoreAmount = 0f;
        scoreIncreasedPerSecond = 1;
        
    }

    void Update()
    {
        AddScore();
    }

    public void AddScore()
    {
        scoreText.text = "Score: " + (int)scoreAmount;
        scoreAmount += scoreIncreasedPerSecond * Time.deltaTime;
        AddHighScore((int)scoreAmount);
    }
    
    public void AddHighScore(int score)
    {
        if (score > highScore)
        {
            highScore = score;
        }
    }

}
