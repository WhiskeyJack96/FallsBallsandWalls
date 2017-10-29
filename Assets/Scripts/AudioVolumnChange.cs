using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVolumnChange : MonoBehaviour {

    public float MusicVolumn;

    public void VolumnChange(float newVolumn)
    {
        MusicVolumn = newVolumn / 100;
        AudioListener.volume = MusicVolumn;
    }
    	
	// Update is called once per frame
	void Update () {

	}
}
