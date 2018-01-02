using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreCrontroller : MonoBehaviour {
	private int score = 0;

	void Start() {
		GetComponent<Text> ().text = "Score: " + score;
	}

	public void incrementScore () {
		score += 75;
		GetComponent<Text> ().text = "Score: " + score;
	}
}
