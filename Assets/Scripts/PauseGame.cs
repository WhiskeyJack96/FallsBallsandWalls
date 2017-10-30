using UnityEngine;
using System.Collections;
using UnityEngine.UI; //Need this for calling UI scripts

public class PauseGame : MonoBehaviour {

	public Transform UIPanel; //Will assign our panel to this variable so we can enable/disable it
	public Player1SizeChanging p;
	private bool isPaused; //Used to determine paused state
    public GameObject Money;

	void Start ()
	{
		UIPanel.gameObject.SetActive(false); //make sure our pause menu is disabled when scene starts
		isPaused = false; //make sure isPaused is always false when our scene opens
        Money = GameObject.Find("Text_Money");
	}

	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Escape) && !isPaused && !p.GameOver)
			Pause();
		else if(Input.GetKeyDown(KeyCode.Escape) && isPaused && !p.GameOver)
			UnPause();
	}

	public void Pause()
	{
		isPaused = true;
		UIPanel.gameObject.SetActive(true); //turn on the pause menu
		Time.timeScale = 0.0f; //pause the game
        Money.gameObject.SetActive(false);
	}

	public void UnPause()
	{
		isPaused = false;
		UIPanel.gameObject.SetActive(false); //turn off pause menu
		Time.timeScale = 1.0f; //resume game
        Money.gameObject.SetActive(true);
    }
}