using UnityEngine;
using System.Collections;

public class PlinkoScript : MonoBehaviour {

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update() {
			Debug.Log (Input.GetAxis ("Horizontal"));
			rb.AddForce (new Vector3 (20, 0, 0) * Input.GetAxis ("Horizontal"));
	}
}