using UnityEngine;
using System.Collections;

public class CollisionListener : MonoBehaviour {

	void OnTriggerEnter(Collider otherObject) {}

	void OnCollisionEnter( Collision thisCollision){
		if ( thisCollision.gameObject.name == "CubeOne") {
			Debug.Log ( "Physics Collision" );
		}
	}
}