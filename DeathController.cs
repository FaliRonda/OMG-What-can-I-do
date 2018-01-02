using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathController : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.layer == 8) {
			GameObject.FindGameObjectWithTag ("Score").GetComponent<ScoreCrontroller> ().incrementScore ();
			GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<AudioController> ().zombieDead ();
			Destroy (gameObject);
			Destroy (other.gameObject);
		}
	}
}
