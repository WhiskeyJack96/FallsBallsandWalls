using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour {

	public GameObject cave;
	public GameObject hole;
	public GameObject bump;
	public int money = 0;
	public int caveCost = 20;
	public int holeCost = 20;
	public int bumpCost = 20;
	public int extraCost = 5;
	public float scaleSpeed = 2.0f;
	public OffscreenCheck playerMove;
	public float maxCave = 1.25f;
	public float maxBump = 2.0f;
    public GameObject hole_left;
    public GameObject hole_right;

	private float lastTime;
	private float deltaTime;
	private GameObject caveClone;
	private Transform caveTop;
	private GameObject bumpClone;
    private GameObject holeClone;
    private Transform child_hole_right;
    private Transform child_hole_left;

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
			caveClone = Instantiate (cave, new Vector3 (0, 0, 0), new Quaternion (0, 0, 0, 0));
			caveTop = caveClone.transform.GetChild (0);
			caveTop.parent = caveClone.transform.GetChild (0);
			money -= caveCost;
		}
		else if (Input.GetKey (KeyCode.LeftArrow) && (money >= extraCost) && (caveTop.localScale.y <= maxCave))
		{
			if (caveClone != null)
			{
				caveTop.localScale += new Vector3(0, 1, 0) * scaleSpeed * Time.deltaTime;
				caveTop.position -= new Vector3 (0, 1, 0) * scaleSpeed * Time.deltaTime / 2;
			}

			money -= extraCost;
		}

		if(Input.GetKeyDown(KeyCode.RightArrow) && (money >= bumpCost))
		{
			bumpClone = Instantiate (bump, new Vector3 (0, -1.5f, 0), new Quaternion (0, 0, 0, 0));
			bumpClone.transform.parent = bump.transform;
			money -= caveCost;
		}
		else if (Input.GetKey (KeyCode.RightArrow) && (money >= extraCost) && (bumpClone.transform.localScale.y <= maxBump))
		{
			if (bumpClone != null)
			{
				bumpClone.transform.localScale += new Vector3(0, 1, 0) * scaleSpeed * Time.deltaTime;
				bumpClone.transform.position += new Vector3 (0, 1, 0) * scaleSpeed * Time.deltaTime / 2;
			}

			money -= extraCost;
		}

        if (Input.GetKeyDown(KeyCode.DownArrow) && (money >= holeCost))
        {
            holeClone = Instantiate(hole, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
            money -= holeCost;
            child_hole_left = holeClone.gameObject.transform.GetChild(0);
            child_hole_right = holeClone.gameObject.transform.GetChild(1);

        }

        if (Input.GetKey(KeyCode.DownArrow) && (money >= extraCost) && (Mathf.Abs(child_hole_left.position.x - child_hole_right.position.x) < 4))
        {

            if (holeClone != null)
            {

                child_hole_left.position -= new Vector3(.05f, 0, 0);

                child_hole_right.position += new Vector3(.05f, 0, 0);



            }
        }
    }
}

