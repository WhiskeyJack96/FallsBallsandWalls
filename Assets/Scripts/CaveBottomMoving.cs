using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveBottomMoving : MonoBehaviour
{
    private float accel = 0.00001f;
    private float vel = 0.05f;
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        // Decrease x pos
        float posX = transform.position.x - vel;

        // Increase vel change each update
        vel -= accel;

        // Update CaveBottom pos
        transform.position = new Vector3(posX, transform.position.y, transform.position.z);
    }
}
