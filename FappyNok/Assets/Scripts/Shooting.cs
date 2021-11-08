using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float cooldownTime;
    private float nextFireTime = 0.0f;

    ScoreManager scoreManager;

    public GameObject GameOverUI;

    private void Start()
    {
        
    }

    void Update()
    {
        
        if (Time.time > nextFireTime)
        {
           if (Input.GetMouseButtonDown(0))
            {
                Shoot();
                nextFireTime = Time.time + cooldownTime;
            } 

        }

    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bomb")
        {
            GameOver();
        }

        /*if(collision.gameObject.tag == "Enemy")
        {
            ScoreManager.AddScoreKill();
        }*/
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        GameOverUI.SetActive(true);
    }

    void Shoot()
    {
        // Debug.Log("Shoot");
        Bullet b = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation).GetComponent<Bullet>();
        b.GameOverUI = GameOverUI;

        
    }
}
