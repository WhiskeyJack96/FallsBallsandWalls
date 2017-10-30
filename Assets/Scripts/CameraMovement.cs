using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public float accel = 0.00001f;
	private float vel = 0.05f;

	void FixedUpdate() {
		// Increase x pos
		float posX = transform.position.x + vel;

		// Increase vel change each update
		vel += accel;	

		// Update camera pos
		transform.position = new Vector3(
								 	posX,
									transform.position.y,
									transform.position.z
								 );		
	}

}
