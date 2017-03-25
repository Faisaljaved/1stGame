using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Handler : MonoBehaviour {
	private Animator myAnim;
	private float startTime;


	// Use this for initialization
	void Start () {
		myAnim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		
		if(Time.time > (startTime + 0.3f )){
				myAnim.SetBool ("jump", false);
			}
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
		if (Input.GetKeyUp ("space")) {
			myAnim.SetBool ("jump", true);
			startTime = Time.time;

		}
	}
	void OnCollisionEnter2D(Collision2D bCollision)
	{
		
	
			myAnim.Play ("Player_idle");

}
}
