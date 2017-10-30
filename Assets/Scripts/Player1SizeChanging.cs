using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player1SizeChanging : MonoBehaviour{
	public Transform UIPanelLose;
	public Transform UIPanelWin;
	public float maxVal = 7.3f;
	public float minVal = 1.5f;
	public float quickChange = 6f;
	public float slowChange = 0.5f;

    // The maximum size of the ball
	private Vector3 V_MaxRadius;
    // The minimum size of the ball
	private Vector3 V_MinRadius;
    // The ball;
    private Rigidbody2D FallBall;
	private OffscreenCheck FallBallCheck;
	public int charges = 0;

	public int jumpStrength = 75;
	public int maxCharge = 3;
	public float waitTime = 5;
    //
    //
    private void Awake()
    {
        FallBall = GetComponent<Rigidbody2D>();
		FallBallCheck = GetComponent<OffscreenCheck> ();
    }

	void Start()
	{
		UIPanelLose.gameObject.SetActive (false);
		UIPanelWin.gameObject.SetActive (false);
		V_MaxRadius = new Vector3(maxVal, maxVal, 0);
		V_MinRadius = new Vector3(minVal, minVal, 0);
		charges = maxCharge;
		StartCoroutine(Recharge());
	}

    //
    // Update is called once per frame
	void Update()
	{
		if (Time.time > 90f)
		{
			UIPanelWin.gameObject.SetActive (true);
			Time.timeScale = 0f;
		}
	}

    void FixedUpdate()
    {   
        if (Input.GetKeyDown (KeyCode.S) && charges > 0)
        {
            FallBall.AddForce (new Vector3(1, 1, 0) * jumpStrength * FallBall.transform.localScale.x / V_MaxRadius.x);
            charges--;
        }
        // Widen the object by 0.5 (Press W) or by 5 (Press W + LeftShift)
        if (Input.GetKey(KeyCode.W))// & (FallBall.transform.lossyScale.magnitude <= V_MaxRadius.magnitude))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
				FallBall.transform.localScale += new Vector3(quickChange, quickChange, 0);
            }
            else
            {
				FallBall.transform.localScale += new Vector3(slowChange, slowChange, 0);
            }
            if (FallBall.transform.lossyScale.x > V_MaxRadius.x)
            {
                FallBall.transform.localScale = V_MaxRadius;
            }
        }
        // Narrow the object by 0.5 (Press S) or by 5 (Press S + LeftShift)

        if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
				FallBall.transform.localScale -= new Vector3(quickChange, quickChange, 0);
            }
            else
            {
				FallBall.transform.localScale -= new Vector3(slowChange, slowChange, 0);
            }
            if (FallBall.transform.lossyScale.x < V_MinRadius.x)
            {
                FallBall.transform.localScale = V_MinRadius;
            }
        }
    }

	IEnumerator Recharge()
	{
		while (true)
		{
			yield return new WaitForSeconds (waitTime);
			charges = maxCharge;
		}
	}

	void OnBecameInvisible()
	{
		if (FallBallCheck.CheckRightBorder ())
		{
			UIPanelWin.gameObject.SetActive (true);
		}
		else
		{
			UIPanelLose.gameObject.SetActive (true);
		}

		Time.timeScale = 0f;
	}
}