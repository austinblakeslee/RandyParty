using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreObject : ScriptableObject {

	public int score;
	private int stainValue;

	public ScoreObject(int scoreVal) {
		score = scoreVal;
		stainValue = 50;
	}

	public int getScore() {
		return score;
	}

	public void setScore(int newScore) {
		score = newScore;
	}

	public int getStainValue() {
		return stainValue;
	}

	public void scoreStain() {
		score += stainValue;
	}
}
