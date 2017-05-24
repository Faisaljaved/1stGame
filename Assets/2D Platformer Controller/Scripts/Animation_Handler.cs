using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Handler : MonoBehaviour {
	public Animator myAnim;
   // private float startTime;
	private float vVelocity;
    private Rigidbody2D rigidPlayer;

	// Use this for initialization
	void Start () {
		myAnim = GetComponent<Animator> ();
		rigidPlayer = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	
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
		{
			if (Input.GetKeyUp ("space")) {
				myAnim.SetBool ("jump", true);
				//startTime = Time.time;
			} //else if (rigidPlayer.velocity.y < 0.01f) {
				//myAnim.SetBool ("jump", false);
			//}
		}
	}
	void OnCollisionEnter2D(Collision2D bCollision)
	{
		if (bCollision.collider.gameObject.layer == LayerMask.NameToLayer ("Obstacles2")) {
			
			//myAnim.SetTrigger ("collided");
		}

}
}
