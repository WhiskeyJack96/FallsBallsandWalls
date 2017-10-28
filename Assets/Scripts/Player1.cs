using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player1 : MonoBehaviour{
        private float v_MaxSize = 50f;                    // The maximum radius of the ball.
        private float v_MinSize = 5f;                     // The minimum radius of the ball.
        private Rigidbody2D FallBall;                     // The ball

        //KeyCode key_Increase = KeyCode.W;                  // Press W to increase the size
        //KeyCode key_Decrease = KeyCode.S;                  // Press S to increase the size  

        // Use this for initialization
        void Start(){

        }

    // Update is called once per frame
        void Update(){
        // Widen the object by 0.1
        //if (Input.GetKeyDown("W")){
            //Event e = Event.current;
            //if (){
                FallBall.transform.localScale = new Vector3(0.1f, 0.1f, 0);
            //}
        //}
        }
}
