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
		if (Input.GetButtonDown("Horizontal")) {
			myAnim.SetBool ("walk", true);
		} else if(Input.GetButtonUp("Horizontal")) {
			myAnim.SetBool ("walk", false);
		}
	}
}
