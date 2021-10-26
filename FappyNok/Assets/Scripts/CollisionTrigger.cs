using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts
{
    
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
                Time.timeScale = 0f;
                Debug.Log("GAME OVER");

            }
        }
    }
}