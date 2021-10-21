using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float cooldownTime;
    private float nextFireTime = 0.0f;
   
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

    void Shoot()
    {
        // Debug.Log("Shoot");
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
