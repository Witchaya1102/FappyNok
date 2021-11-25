using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            anim.SetInteger("Anima", 1);
        }
        
        if (Input.GetKeyUp("space"))
        {
            anim.SetInteger("Anima", 0);
        }
    }
}
