using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

	public void NewGameLevel(string newLevel) {
		SceneManager.LoadScene (newLevel);
	}

	public void QuitGame() {
		Application.Quit ();
	}

}
