using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;

    public void Setup(ScoreManager score, ScoreManager highScore)
    {
        gameObject.SetActive(true);
        highScoreText.text = ($"HIGHSCORE: {highScore.ToString()}");
        scoreText.text = ($"SCORE: {score.ToString()}");
    }
}
