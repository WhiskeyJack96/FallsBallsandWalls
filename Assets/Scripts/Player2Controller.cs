using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour {

	public GameObject cave;
	public GameObject hole;
	public int money = 0;
	public int caveCost = 20;
	public int holeCost = 20;
	public int extraCost = 5;
	public float scaleSpeed = 2.0f;
	public OffscreenCheck playerMove;

	private float lastTime;
	private float deltaTime;
	private GameObject caveClone;
	private int x = 0;

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
			caveClone = Instantiate (cave, new Vector3 (x, 3, 0), new Quaternion (0, 0, 0, 0));
			caveClone.transform.parent = cave.transform;
			money -= caveCost;
			x += 5;
		}

		if (Input.GetKey (KeyCode.LeftArrow) && (money >= extraCost) && (caveClone.transform.localScale.y <= 8))
		{
			if (caveClone != null)
			{
				caveClone.transform.localScale += new Vector3(0, 1, 0) * scaleSpeed * Time.deltaTime;
				caveClone.transform.position -= new Vector3 (0, 1, 0) * scaleSpeed * Time.deltaTime / 2;
			}

			money -= extraCost;
		}

		if (Input.GetKeyDown (KeyCode.DownArrow) && (money >= holeCost))
		{
			Instantiate (hole, new Vector3 (5, 1, 0), new Quaternion (0, 0, 0, 0));
			money -= holeCost;
		}
	}
}
