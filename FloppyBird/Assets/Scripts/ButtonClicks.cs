using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ButtonClicks : MonoBehaviour {

	public void LoadGame () {
		Application.LoadLevel(1);
	}
	
	public void CloseGame() {
		Application.Quit();
	}
}
