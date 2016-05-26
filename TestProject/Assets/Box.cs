using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour {
	private Rigidbody rgbd;
	private RaycastHit hit;
	private Vector3 down;
	public float distance;
	private bool grounded;
	public float speed= 100;
	void Start (){
		down = transform.TransformDirection (Vector3.down);
		rgbd = GetComponent<Rigidbody> ();
	}
	void FixedUpdate (){
		
		if (Physics.Raycast (transform.position, down, out hit,1)) {
			grounded = true;

		} else {
			grounded = false;
		
		} 


		Debug.DrawRay (transform.position, down, Color.blue);
		if (Input.GetKey (KeyCode.W) && grounded == true) {
			rgbd.AddForce (0, 0, speed);
		
		}

		if (Input.GetKey (KeyCode.S) && grounded == true) {
			rgbd.AddForce (0, 0, -speed);

		}if (Input.GetKey (KeyCode.A) && grounded == true) {
			rgbd.AddForce (-speed, 0,0);

		}
		if (Input.GetKey (KeyCode.D) && grounded == true) {
			rgbd.AddForce (-speed, 0,0);

		}
		if (Input.GetKeyDown (KeyCode.Space) && grounded == true) {
			rgbd.AddForce (0, speed*2,0);

		}
	}

}
