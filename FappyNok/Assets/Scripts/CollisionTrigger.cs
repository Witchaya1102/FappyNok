using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;



public class CollisionTrigger : MonoBehaviour
    {
        bool isPlayerDead = false;


        void OnCollisionEnter2D(Collision2D collision)
        {

            if (collision.gameObject.tag == "Player") //for floor
            {
                Debug.Log("Player Dead");
                isPlayerDead = true;
            }

            if (collision.gameObject.tag == "Bullet") //for bullet
            {
                Debug.Log("Destroy");
                Destroy(gameObject);
            }

            if (collision.gameObject.tag == "Enemy") //for player
            {
                Debug.Log("Player Dead");
                isPlayerDead = true;
            }

            if (collision.gameObject.tag == "Finish") //for de-spawn enemy/bullet
            {
                Destroy(gameObject);
            }

            if (isPlayerDead == true) //check: player status
            {
                GameOver();
                Debug.Log("GAME OVER");

            }
        }

        public void GameOver()
        {
            Time.timeScale = 0f;
            /*GameOverUI.Setup(score, highScore);*/ //ยังติดแดง ไปต้อไม่ถูก
        }
    
    
        //score manager
        public Text scoreText;
        public int highScore;
        public int score;
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
            score = (int)scoreAmount;
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
