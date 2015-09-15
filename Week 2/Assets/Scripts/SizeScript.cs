using UnityEngine;
using System.Collections;

public class SizeScript : MonoBehaviour {

	private GameObject RedDomino;

	// Use this for initialization
	void Start () {
		RedDomino = GameObject.Find ("RedDomino");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Mouse0) == true) {
			RedDomino.transform.localScale = RedDomino.transform.localScale + new Vector3 (0, .1f, 0);
		}
		if (Input.GetKey (KeyCode.Mouse1) == true) {
			RedDomino.transform.localScale = RedDomino.transform.localScale - new Vector3 (0, .1f, 0);
		}
	}
}
