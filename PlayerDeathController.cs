using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathController : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.layer == 9) {
			GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<AudioController> ().playerDead ();
			Destroy (gameObject);
		}
	}
}
