using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopGame : MonoBehaviour
{	
	public void Start () {
        Time.timeScale = 0.0f; //pause the game
    }
}
