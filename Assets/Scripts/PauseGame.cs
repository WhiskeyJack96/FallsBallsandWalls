using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Need this for calling UI scripts

public class PauseGame : MonoBehaviour {

	public Transform UIPanel; //Will assign our panel to this variable so we can enable/disable it

	private bool isPaused; //Used to determine paused state

	void Start ()
	{
		UIPanel.gameObject.SetActive(false); //make sure our pause menu is disabled when scene starts
		isPaused = false; //make sure isPaused is always false when our scene opens
	}

	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Escape) && !isPaused)
			Pause();
		else if(Input.GetKeyDown(KeyCode.Escape) && isPaused)
			UnPause();
	}

	public void Pause()
	{
		isPaused = true;
		UIPanel.gameObject.SetActive(true); //turn on the pause menu
		Time.timeScale = 0.0f; //pause the game
	}

	public void UnPause()
	{
		isPaused = false;
		UIPanel.gameObject.SetActive(false); //turn off pause menu
		Time.timeScale = 1.0f; //resume game
	}
}