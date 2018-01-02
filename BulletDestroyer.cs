using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyer : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.layer == 8) {
			Destroy (other.gameObject);
		}
	}
}
