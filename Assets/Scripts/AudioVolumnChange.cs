using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AudioVolumnChange : MonoBehaviour
{
    public void AudioChange(float newVolumn)
    {
        UnityEngine.AudioListener.volume = newVolumn;
    }

}
