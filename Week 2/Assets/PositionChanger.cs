using UnityEngine;
using System.Collections;

public class PositionChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log (gameObject.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		//gameObject.transform.position = new Vector3 ( 1.1f, 5, 4);
		gameObject.transform.position = gameObject.transform.position + new Vector3 (.01f, .01f, 0);
	
	}
}
