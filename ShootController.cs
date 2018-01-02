using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour {
	public GameObject[] guns;
	int cont = 0;
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump")) {
			guns [cont].GetComponent<GunController> ().fire ();
			cont++;
			if (cont >= guns.Length)
				cont = 0;
		}
	}
}
