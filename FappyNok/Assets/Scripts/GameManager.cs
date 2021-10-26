using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public void EndGame()
    {
        Debug.Log("GAME OVER");
        StopGame();
    }

    void StopGame()
    {
        Time.timeScale = 0f;
    }
}
