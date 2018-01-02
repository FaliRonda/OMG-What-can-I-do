using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour {
	private GameObject player;
	public GameObject[] elements;
	
	// Update is called once per frame
	void Update () {
		player = GameObject.FindGameObjectWithTag ("Player");
		if (!player) {
			foreach(GameObject element in elements) {
				element.SetActive (true);
			}
		}
	}
}
