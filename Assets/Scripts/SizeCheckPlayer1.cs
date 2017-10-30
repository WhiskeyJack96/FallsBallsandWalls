using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeCheckPlayer1 : MonoBehaviour {

    public Rigidbody2D FallBall;
    public LayerMask mask = -1;
    //
    //
    private void Awake()
    {
       
    }

    // Use this for initialization
    void Start () {
		
	}
	

	// Update is called once per frame
	void Update () {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(0, 1), 10f, mask);


        
        if (hit.collider != null)
        {
            print(hit.distance);

            float ballRadius = FallBall.gameObject.GetComponent<CircleCollider2D>().radius;
            float ballScaleY = FallBall.gameObject.GetComponent<Transform>().localScale.y;
            float trueRadius = ballRadius * ballScaleY;
            print(ballRadius);
            //print();
            if (hit.distance< trueRadius)
            {
                FallBall.transform.localScale= new Vector3(hit.distance, hit.distance,0f);
            }
        }
	}
}
