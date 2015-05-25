using UnityEngine;
using System.Collections;

public class BirdCollision : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D collidedWith) {
		if (collidedWith.gameObject.tag == "Pipe") {
			Debug.Log ("Hit pipe");
		}
		else if (collidedWith.gameObject.tag == "PassedPipe") {
			Debug.Log ("Passed pipe");
		}
	}
}
