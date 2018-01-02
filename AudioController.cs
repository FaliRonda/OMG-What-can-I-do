using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {
	private AudioSource[] audios;

	// Use this for initialization
	void Start () {
		this.audios = GetComponents<AudioSource> ();
	}
	
	public void playerDead() {
		audios [1].Play ();
	}

	public void zombieDead() {
		audios [2].Play ();
	}

	public void button() {
		audios [3].Play ();
	}
}
