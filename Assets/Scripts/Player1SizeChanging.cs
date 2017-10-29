using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player1SizeChanging : MonoBehaviour{
    // The maximum size of the ball
    private Vector3 V_MaxRadius = new Vector3(12.2f, 12.2f, 0);
    // The minimum size of the ball
    private Vector3 V_MinRadius = new Vector3(1f, 1f, 0);
    // The ball;
    private Rigidbody2D FallBall;
	public int jumpStrength;
    //
    //
    private void Awake()
    {
        FallBall = GetComponent<Rigidbody2D>();
    }

    //
    // Update is called once per frame
    void FixedUpdate()
    {   
        // Widen the object by 0.5 (Press W) or by 5 (Press W + LeftShift)
        if (Input.GetKey(KeyCode.W))// & (FallBall.transform.lossyScale.magnitude <= V_MaxRadius.magnitude))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                FallBall.transform.localScale += new Vector3(5f, 5f, 0);
            }
            else
            {
                FallBall.transform.localScale += new Vector3(0.5f, 0.5f, 0);
            }
            if (FallBall.transform.lossyScale.x > V_MaxRadius.x)
            {
                FallBall.transform.localScale = V_MaxRadius;
            }
        }
        // Narrow the object by 0.5 (Press S) or by 5 (Press S + LeftShift)
		if (Input.GetKeyDown (KeyCode.S))
		{
			FallBall.AddForce (Vector2.up * jumpStrength);
		}

        if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                FallBall.transform.localScale -= new Vector3(5f, 5f, 0);
            }
            else
            {
                FallBall.transform.localScale -= new Vector3(0.5f, 0.5f, 0);
            }
            if (FallBall.transform.lossyScale.x < V_MinRadius.x)
            {
                FallBall.transform.localScale = V_MinRadius;
            }
        }

    }
}