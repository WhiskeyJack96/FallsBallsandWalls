using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

	public LayerMask mask = -1;
	public AudioSource roll;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(0, -1), .1f, mask);


        
        if (hit.collider == null)
        {
        	roll.mute = true;
        }
        else{
        	roll.mute = false;
        }
	}
}
