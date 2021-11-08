using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class Enemy_Mob : MonoBehaviour
{
    public float speed;

    ScoreManager scoreManager;

    private void Start()
    {
        scoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();
    }

    void Update()
    {
        transform.position += ((Vector3.left * speed) * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
            AddScoreKill();
        }
    }

    public void AddScoreKill()
    {
        scoreManager.AddScoreKill();
    }
}

