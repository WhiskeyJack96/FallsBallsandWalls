using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeCheckPlayer1 : MonoBehaviour {

    public Rigidbody2D FallBall;
    public Vector3 temp_max = new Vector3(0, 0, 27);
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
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(0, 1), .1f, mask);


        
        if (hit.collider != null)
        {
            print(temp_max);
            
            if (FallBall.transform.localScale.y > temp_max.y)
            {
                if (temp_max.z == 27)
                {
                    temp_max = FallBall.transform.localScale;

                }
                FallBall.transform.localScale = temp_max;
            }
            

        }
        else
        {
            temp_max = new Vector3(0, 0, 27);
        }
	}
}
