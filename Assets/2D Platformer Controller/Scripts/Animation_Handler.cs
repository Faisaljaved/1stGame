using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Handler : MonoBehaviour {
	private Animator myAnim;
	private Rigidbody2D rigid;
	public float velocity;


	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D>();
		myAnim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		
		myAnim.SetFloat ("jumpVelocity",rigid.velocity.y);

		Check ();
	}
	private void Check(){
		if (Input.GetKeyDown ("left")) {
			myAnim.SetBool ("invertwalk", true);
			myAnim.SetBool ("invert", true);
		} else if (Input.GetKeyUp ("left")) {
			myAnim.SetBool ("invertwalk", false);

		}
		
		if (Input.GetKeyDown("right")) {
			myAnim.SetBool ("invert", false);

			myAnim.SetBool ("walk", true);
		} else if(Input.GetKeyUp("right")) {
			myAnim.SetBool ("walk", false);
		}

	}
}
