using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioVolumnChange : MonoBehaviour {

    public void VolumnChange(float MusicVolumn)
    {
        AudioListener.volume = MusicVolumn;
    }
    	
}
