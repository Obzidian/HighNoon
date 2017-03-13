using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float valueRemaining = 10;
	public float valueMaximum = 30;
	public float valueConsumptionRate = 1f;

	public Text timerText;

	// allows for pausing the game to stop the timer from running
	public bool gameInProgress = true;

	
	// Update is called once per frame
	void Update () {
		if (gameInProgress) {
			valueRemaining -= Time.deltaTime * valueConsumptionRate;
			timerText.text = "Time Remaining: " + Mathf.Round (valueRemaining).ToString ();

			if (valueRemaining < 0) {
				gameInProgress = false;
				endGameWithFailure ();
			}
		}
	}

	void endGameWithFailure(){
		
	}
}
