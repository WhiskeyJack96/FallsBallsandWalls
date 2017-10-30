using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    Transform trans;
    public Rigidbody2D FallBall;
    public Transform Pause;

    void Awake()
    {
        trans = FallBall.transform;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!Pause.gameObject.activeSelf) {
            trans.Rotate(0, 0, -10);
        }


    }
}
