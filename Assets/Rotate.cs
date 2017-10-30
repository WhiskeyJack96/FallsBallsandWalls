using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    Transform trans;
    public Rigidbody2D FallBall;

    void Awake()
    {
        trans = FallBall.transform;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        trans.Rotate(0, 0, -10);


    }
}
