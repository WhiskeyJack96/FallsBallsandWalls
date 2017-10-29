using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextUpdater : MonoBehaviour {

	private Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
	}
	public void updateText(string s)
	{
		text.text = s;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
