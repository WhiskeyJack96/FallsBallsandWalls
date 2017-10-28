using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffscreenCheck : MonoBehaviour {
	public float objDistance=-2.0f;
	void FixedUpdate() {
		CheckInBounds();
	}

	public bool CheckInBounds() {
		float safeDistance = GetSafeDistance();
		if (transform.position.x >= safeDistance) {
			return true;
		} else {
			//print ("OUT OF BOUNDS");
			return false;
		}
	}

	float GetSafeDistance() {
		float maxCamDistance = GetMaxCamDistance();
		//float objDistance = 0f;	//Object width
		return maxCamDistance + objDistance;
	}

	float GetMaxCamDistance() {
		Camera cam = Camera.main;
		Vector3 camPos = cam.gameObject.transform.position;
		float camHeight = 2f * cam.orthographicSize;
		float camWidth = camHeight * cam.aspect;
		return camPos.x - (camWidth / 2);
	}

}
