using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float speed;

    //public GameObject pickupEffect;

    void Update()
    {
        transform.position += ((Vector3.left * speed) * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Pickup();
        }
    }

    void Pickup()
    {
        //Instantiate(pickupEffect, transform.position, transform.rotation);

        //Apply Effect to Player

        Destroy(gameObject);
    }
}
