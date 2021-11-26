using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    /*public float jumpHeight = -500f;

    private Rigidbody2D rigidBody2D;
 
    private void Start ()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }
    private void Update ()
    {
        if (Input.GetKeyDown (KeyCode.Space)) // both conditions can be in the same branch
        { 
            Debug.Log("Jump");
            rigidBody2D.velocity = Vector2.up * jumpHeight; // you need a reference to the RigidBody2D component
        }
    }*/
    public float velocity = 50f;
    private Rigidbody2D rigidBody;
    public GameObject spacetostartText;
    public GameObject controlsTipsText;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        Time.timeScale = 0f;
    }

 
    void Update()
    {
        if(Input.GetKey("space"))
        {
            rigidBody.velocity = Vector2.up * velocity;
        }

        if (Input.GetKey("space"))
        {
            spacetostartText.SetActive(false);
            Time.timeScale = 1f;
        }
        if (Input.GetKey("e"))
        {
            Time.timeScale = 0f;
        }
    }
}
