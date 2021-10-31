using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    public int score;
    public int highScore;

    public void Setup(int score, int highScore)
    {
        gameObject.SetActive(true);
        highScoreText.text = ($"HIGHSCORE: {highScore}");
        scoreText.text = ($"SCORE: {score}");
    }
}
