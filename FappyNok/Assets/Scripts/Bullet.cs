using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    public GameObject GameOverUI;


    void Start()
    {
        rb.velocity = transform.right * speed;
        
    }    


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Bomb")
        {
            Debug.Log("Hit Bomb");
            Destroy(gameObject);
            GameOver();
        }
        
    }
    
    public void GameOver()
    {
        Time.timeScale = 0f;
        GameOverUI.SetActive(true);
    }

}
