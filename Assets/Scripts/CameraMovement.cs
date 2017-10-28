using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	private float accel = 0.0001f;
<<<<<<< HEAD
	private float vel = 0f;
=======
	private float vel = 0.005f;
>>>>>>> 76d46b76f8c808dd1bd03fdf24cc9fd428e39b06

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
