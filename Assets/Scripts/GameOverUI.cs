using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverUI : MonoBehaviour {

	void EndGame(int winner) {
		DisplayGameOverUI();
		/*
		 * Will need a function that uses the int parameter
		 * and makes an end screen image visible that
		 * displays which player won 
		 */
	}

	void DisplayGameOverUI() {
		GameObject UI = GameObject.Find("GameOverUI");
		UI.GetComponent<CanvasGroup>().alpha = 1f;
		UI.GetComponent<CanvasGroup>().interactable = true;
	}
}
