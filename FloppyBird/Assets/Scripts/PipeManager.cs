using UnityEngine;
using System.Collections;

public class PipeManager : MonoBehaviour {

	private const int NUM_OF_PIPE_PAIRS = 4;
	private GameObject[] pipePairArray;
	private GameObject[] pipeTopArray;
	private GameObject[] pipeBottomArray;
	private GameObject[] passedPipeMarkArray;

	// Use this for initialization
	void Start () {	
		pipeTopArray = new GameObject[NUM_OF_PIPE_PAIRS];
		pipeTopArray = GameObject.FindGameObjectsWithTag("PipeTop");
		
		pipeBottomArray = new GameObject[NUM_OF_PIPE_PAIRS];
		pipeBottomArray = GameObject.FindGameObjectsWithTag("PipeBottom");
		
		pipePairArray = new GameObject[NUM_OF_PIPE_PAIRS];
		pipePairArray = GameObject.FindGameObjectsWithTag("PipePair");
		
		passedPipeMarkArray = new GameObject[NUM_OF_PIPE_PAIRS];
		passedPipeMarkArray = GameObject.FindGameObjectsWithTag("PassedPipe");
	}
	
	// Update is called once per frame
	void Update () {
		movePipes ();
		movePipesToBack ();
	}

	void movePipesToBack ()
	{
		foreach (GameObject pipeTop in pipeTopArray) {
			if (pipeTop.transform.position.x < -625) {
				pipeTop.transform.position = new Vector2 (-172, Random.Range (-75, -20));
			}
		}
		foreach (GameObject pipeBottom in pipeBottomArray) {
			if (pipeBottom.transform.position.x < -625) {
				pipeBottom.transform.position = new Vector2 (-172, Random.Range (-285, -225));
			}
		}
		foreach (GameObject passedPipeMark in passedPipeMarkArray) {
			if (passedPipeMark.transform.position.x < -625) {
				passedPipeMark.transform.position = new Vector2 (-172, -172);
			}
		}
	}

	void movePipes ()
	{
		foreach (GameObject pipePair in pipePairArray) {
			pipePair.transform.Translate (new Vector2 (-1.0f, 0.0f));
		}
	}
}
