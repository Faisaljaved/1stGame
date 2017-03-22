using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Handler : MonoBehaviour {
	private Animator myAnim;
	private float change;


	// Use this for initialization
	void Start () {

		myAnim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	
		Check ();
	}
	private void Check(){
		if (Input.GetKeyDown ("left")) {
			myAnim.SetBool ("invert", true);
			myAnim.SetBool ("invertwalk", true);
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
