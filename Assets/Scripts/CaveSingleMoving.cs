using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveSingleMoving : MonoBehaviour
{

	// Update is called once per frame
	void Update ()
    {
		if (transform.position.x < -12)
        {
            transform.Translate(24f,0,0);
        }
	}
}
