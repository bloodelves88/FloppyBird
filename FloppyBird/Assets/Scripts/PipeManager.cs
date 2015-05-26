using UnityEngine;
using System.Collections;

public class PipeManager : MonoBehaviour {

	private const int NUM_OF_PIPE_PAIRS = 4;
	private GameObject[] pipePairArray;
	private GameObject[] pipeTopArray;
	private GameObject[] pipeBottomArray;
	private GameObject[] passedPipeMarkArray;
	
	public bool pipesAreMoving;

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
		
		pipesAreMoving = true;
	}
	
	// Update is called once per frame
	void Update () {
		movePipesToBack();
		if (pipesAreMoving == true) {
			 movePipes();
		}
	}

	void movePipesToBack ()
	{
		int topPipePosition = Random.Range(-95, -45);
		int bottomPipePosition = topPipePosition - 160;
		foreach (GameObject pipeTop in pipeTopArray) {
			if (pipeTop.transform.position.x < -625) {
				pipeTop.transform.position = new Vector2 (-172, topPipePosition);
			}
		}
		foreach (GameObject pipeBottom in pipeBottomArray) {
			if (pipeBottom.transform.position.x < -625) {
				pipeBottom.transform.position = new Vector2 (-172, bottomPipePosition);
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
			pipePair.transform.Translate (new Vector2 (-1.25f, 0.0f));
		}
	}
}
