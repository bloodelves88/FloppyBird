using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BirdCollision : MonoBehaviour {
	[SerializeField] private Text scoreNumber;
	private int scoreInt; 
	
	void Start() {
		scoreInt = 0;
	}
	
	void OnCollisionEnter2D(Collision2D collidedWith) {
		if (collidedWith.gameObject.tag == "Pipe") {
			Debug.Log ("Hit pipe");
		}
		else if (collidedWith.gameObject.tag == "PassedPipe") {
			incrementScore ();
		}
	}

	void incrementScore ()
	{
		scoreInt += 1;
		scoreNumber.text = scoreInt.ToString ("F0");
	}
}
