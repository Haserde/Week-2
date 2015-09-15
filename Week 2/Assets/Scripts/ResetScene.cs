using UnityEngine;
using System.Collections;

public class ResetScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnTriggerEnter(){
		Application.LoadLevel (Application.loadedLevel);
	
	}
}
