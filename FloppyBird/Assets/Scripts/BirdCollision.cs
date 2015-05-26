using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BirdCollision : MonoBehaviour {
	[SerializeField] private Text scoreNumber;
	[SerializeField] private Text bigScoreNumber;
	private int scoreInt; 
	[SerializeField] private PipeManager pipeManagerScript;
	[SerializeField] private LoseAndRestartGame loseAndRestartGameScript;
	
	void Start() {
		scoreInt = 0;
	}
	
	void OnCollisionEnter2D(Collision2D collidedWith) {
		if (collidedWith.gameObject.tag == "PipeBottom" || collidedWith.gameObject.tag == "PipeTop") {
			pipeManagerScript.pipesAreMoving = false;
			loseAndRestartGameScript.lostGame = true;
		}
		else if (collidedWith.gameObject.tag == "PassedPipe") {
			incrementScore ();
		}
	}

	void incrementScore ()
	{
		scoreInt += 1;
		scoreNumber.text = scoreInt.ToString ("F0");
		bigScoreNumber.text = scoreInt.ToString ("F0");
	}
}
