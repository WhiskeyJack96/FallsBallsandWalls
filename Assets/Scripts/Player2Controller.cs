using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour {

	public GameObject cave;
	public GameObject hole;
	public int money = 0;
	public int caveCost = 20;
	public int holeCost = 20;

	private float lastTime;
	private float deltaTime;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		deltaTime = Time.time - lastTime;

		if (deltaTime >= 0.1f)
		{
			lastTime = Time.time;
			money++;
		}
		 
		if(Input.GetKeyDown(KeyCode.LeftArrow) && (money >= caveCost))
		{
			Instantiate (cave, new Vector3 (0, 1, 0), new Quaternion (0, 0, 0, 0));
			money -= caveCost;
		}

		if (Input.GetKeyDown (KeyCode.DownArrow) && (money >= holeCost))
		{
			Instantiate (hole, new Vector3 (5, 1, 0), new Quaternion (0, 0, 0, 0));
			money -= holeCost;
		}
	}
}
