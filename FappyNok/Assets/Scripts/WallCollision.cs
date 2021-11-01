using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.collider.gameObject);
    }

    
}
