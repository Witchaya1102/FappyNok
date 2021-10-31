using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public GameOverUI GameOverUI;
    public int scoreAmount;
    public int highScoreText;

    public void EndGame()
    {
        if(Time.timeScale == 0f)
        {
            Debug.Log("Game Stop");
            //GameOverUI.Setup(scoreAmount, highScoreText);
        }
    }
}
