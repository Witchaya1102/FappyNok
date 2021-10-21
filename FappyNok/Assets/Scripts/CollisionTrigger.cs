using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTrigger : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player Dead");
        }

        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("Destroy");
            Destroy(gameObject);
               
        }

        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Player Dead");
        }

        if (collision.gameObject.tag == "Finish")
        {
            Destroy(gameObject);   
        }



    
    }
}
