using UnityEngine;
using System.Collections;

public class LoseAndRestartGame : MonoBehaviour {

	private float speed; 
	[SerializeField] private GameObject score;
	[SerializeField] private GameObject bigScore;
	public bool lostGame;
	[SerializeField] private GameObject fadedPanel;
	
	// Use this for initialization
	void Start () {
		lostGame = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (lostGame == true) {
			fadedPanel.SetActive(true);
			score.SetActive(false);
			bigScore.SetActive(true);
		}
	}
	
	public void RestartGame() {
		Application.LoadLevel(1);
	}
}
