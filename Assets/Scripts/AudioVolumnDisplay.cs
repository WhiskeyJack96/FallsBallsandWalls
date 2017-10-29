using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioVolumnDisplay : MonoBehaviour {
    public Text AudioText;  

	// Use this for initialization
	void Start () {
        AudioText = GetComponent<Text>();
	}
    
    public void SetSliderValue(float SliderValue)
    {
        AudioText.text = Mathf.Round(SliderValue * 100).ToString();
    }
}
