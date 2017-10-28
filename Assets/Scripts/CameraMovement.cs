using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	private float accel = 0.0001f;
	private float vel = 0f;

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
