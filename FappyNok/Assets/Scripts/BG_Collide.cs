using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Collide : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "End_BG")
        {
            Destroy(gameObject);
        }

    }
}
