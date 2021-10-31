using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy_Bomb : MonoBehaviour
{
    public GameObject GameOverUI;

    void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            Debug.Log("Boom");
            GameOver();
        }

        if (collision.gameObject.tag == "Finish")
        {
            Destroy(gameObject);   
        }

    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        GameOverUI.SetActive(true);
    }
}
