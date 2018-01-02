using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {
	public Transform bulletStart;
	public GameObject bullet;
	public GameObject shootLight;

	private float _instantiateTimer = 0;
	private AudioSource audioSource;


	void Start() {
		audioSource = GetComponent<AudioSource>();
	}

	void Update() {
		if (_instantiateTimer > 0) {
			_instantiateTimer -= Time.deltaTime;
		} else {
			shootLight.SetActive (false);
		}
	}

	public void fire(){
		audioSource.Play ();
		Instantiate (bullet, bulletStart.position, bulletStart.rotation);
		shootLight.SetActive (true);
		_instantiateTimer = 0.07f;
	}
}
