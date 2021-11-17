using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;



public class CollisionTrigger : MonoBehaviour
    {
        bool isPlayerDead = false;
        public GameObject GameOverUI;
    //new code

    GameObject shield;

    private void Start()
    {
        shield = transform.Find("Shield").gameObject;
        DeactivateShield();
    }

    void ActivateShield()
    {
        shield.SetActive(true);
    }

    void DeactivateShield()
    {
        shield.SetActive(false);
    }

    bool HasShield()
    {
        return shield.activeSelf;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PowerUp powerUp = collision.GetComponent<PowerUp>();
        if(powerUp)
        {
            if(powerUp.activateShield)
            {
                ActivateShield();
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
        {
            

            if (collision.gameObject.tag == "Enemy") //for player
            {
                if(HasShield())
                {
                    DeactivateShield();
                    Destroy(collision.collider.gameObject);
                }
                else
                {
                    Debug.Log("Player Dead");
                    isPlayerDead = true;
                }
                
            }

            if (collision.gameObject.tag == "Bomb") //for player
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
        GameOverUI.SetActive(true);
        }

    }   
