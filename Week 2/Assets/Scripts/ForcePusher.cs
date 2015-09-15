using UnityEngine;
using System.Collections;

public class ForcePusher : MonoBehaviour {

	private float xForce;
	private float zTorque;

	private GameObject redCube;
	private GameObject SphereOne;
	
	Rigidbody rb;
	
	// Use this for initialization
	void Start () {
		xForce = 150;
		zTorque = 230;
		redCube = GameObject.Find ("redCube");
		SphereOne = GameObject.Find ("SphereOne");
		rb = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		//when i hit space, move the object
		//if i hit the space key
		//if (the Space Key is pressed) {
		if (Input.GetKey (KeyCode.Space) == true) {
			rb.AddForce (new Vector3 (xForce, 0, 0));
			rb.AddTorque (new Vector3 (0, 0, zTorque));
			redCube.transform.localScale = new Vector3 (2,3,1);
		}

		if (Input.GetKey (KeyCode.Mouse0) == true) {
			SphereOne.transform.localScale = SphereOne.transform.localScale + new Vector3 (.1f, .1f, .1f);
		}

		Debug.Log( Input.GetAxis("Horizontal"));
		rb.AddForce( new Vector3( 20, 0, 0) * Input.GetAxis ("Horizontal") );

	}
}
