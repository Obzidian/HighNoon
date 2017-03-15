using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameAtTouch : MonoBehaviour {

	public bool endWithWin;

	void OnTriggerExit2D(Collider2D target) {
		if (target.gameObject.tag == "Player") {

			if (endWithWin == true) {
				PersistentManager.dataStore.endGameWithWin ();
			} else {
				PersistentManager.dataStore.endGameWithLoss ();
			}
		}
	}
}
