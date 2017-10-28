using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public List<GameObject> floor = new List<GameObject>(15);
	//private Queue<GameObject> floorTiles = new Queue<GameObject>(floor);
	public Camera cam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//for each element in the list
			//if the element is not visible
				// remove it from the list
		//if(true) //get from check camera
		//float xshift = cam.ViewportToWorldPoint(new Vector3(1,.5f,0)).x;
		//Debug.Log(xshift);
		
	}
}
