using UnityEngine;
using System.Collections;

public class PipeMovement : MonoBehaviour {

	private GameObject[] pipePairArray;
	private const int NUM_OF_PIPE_PAIRS = 3;

	// Use this for initialization
	void Start () {	
		pipePairArray = new GameObject[NUM_OF_PIPE_PAIRS];
		pipePairArray = GameObject.FindGameObjectsWithTag("PipePair");
	}
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject pipePair in pipePairArray) {
			pipePair.transform.Translate(new Vector2(-1.0f, 0.0f));
		}
	}
}
