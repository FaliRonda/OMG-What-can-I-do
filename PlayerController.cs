using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float angleSpeed = 5f;
	public float speed = 5f;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		Vector3 rotation = new Vector3(0, 0, -Input.GetAxis ("Horizontal"));
		Vector3 momevent = new Vector3 (0, Input.GetAxis ("Vertical"), 0);

		transform.Rotate (rotation * angleSpeed * Time.deltaTime * 150);
		if(Input.GetAxis ("Vertical") < 0)
			transform.Translate (momevent * (speed/2) * Time.deltaTime);
		else
			transform.Translate (momevent * speed * Time.deltaTime);
	}
}
