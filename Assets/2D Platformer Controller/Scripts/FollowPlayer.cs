using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
	Transform target;
	public float speed = 3f;
	GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
	}

	void Update () {
		transform.position = Vector2.MoveTowards(transform.position,player.transform.position, speed*Time.deltaTime);
	}
}