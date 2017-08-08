using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour {
	public Text scoreShow;
	public ScoreObject score;

	// Use this for initialization
	void Start () {
		score = new ScoreObject (0);
		scoreShow = GameObject.Find ("ScoreTracker").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		scoreShow.text = "Score: " + score.getScore ();
	}

	public void increaseScore(int points) {
		score.setScore (score.getScore() + points);
	}
}
