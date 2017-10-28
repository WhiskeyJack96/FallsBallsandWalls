using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player1 : MonoBehaviour{
    // The maximum size of the ball.
    private Vector3 V_MaxRadius = new Vector3(20f,20f,0);
    // The minimum size of the ball.
    private Vector3 V_MinRadius = new Vector3(-5f, -5f, 0);
    // The ball;
    private Rigidbody2D FallBall;

    //
    //
    private void Awake()
    {
        FallBall = GetComponent<Rigidbody2D>();
    }

    //
    // Update is called once per frame
    void Update()
    {        
        // Widen or Narrow the object by 0.1
        if (Input.GetKeyDown(KeyCode.W) & (FallBall.transform.lossyScale.magnitude <= V_MaxRadius.magnitude))
        {
            FallBall.transform.localScale += new Vector3(0.1f, 0.1f, 0);
        }
        else if (Input.GetKeyDown(KeyCode.S) & (FallBall.transform.lossyScale.magnitude >= V_MinRadius.magnitude))
        {
            FallBall.transform.localScale += new Vector3(-0.1f, -0.1f, 0);
        }
    
    }
}