using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour {
	private Transform target;
	private GameObject player;
	public float speed;

	// Update is called once per frame
	void Update () {
		player = GameObject.FindGameObjectWithTag ("Player");
		if (player) {
			target = player.transform;
			float step = speed * Time.deltaTime;

			Vector3 vectorToTarget = target.position - transform.position;
			float angle = Mathf.Atan2 (vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
			Quaternion q = Quaternion.AngleAxis (angle, Vector3.forward);
			transform.rotation = Quaternion.Slerp (transform.rotation, q, Time.deltaTime * speed);

			transform.position = Vector3.MoveTowards (transform.position, target.position, step);
		}
	}
}
