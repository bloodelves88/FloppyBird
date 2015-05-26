using UnityEngine;
using System.Collections;

public class BirdControl : MonoBehaviour {

	[SerializeField] private GameObject bird;
	private Rigidbody2D bird_rb;
	
	private float lookRotation;
	private float birdXPos;

	// Use this for initialization
	void Start () {
		bird_rb = bird.GetComponent<Rigidbody2D>();
		
		birdXPos = bird.transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		userInput ();
		birdRotation ();
		fixXPos ();
	}

	void fixXPos ()
	{
		Vector3 v3Position = bird.transform.position;
		v3Position.x = birdXPos;
		bird.transform.position = v3Position;
	}

	void userInput ()
	{
		if (Input.GetMouseButtonDown (0)) {
			//bird_rb.AddForce (new Vector2 (0, 2000), ForceMode2D.Impulse);
			bird_rb.velocity = new Vector2(0, 50);
		}
	}

	void birdRotation ()
	{
		lookRotation = bird_rb.velocity.y;
		if (bird_rb.velocity.y > 50.0f) {
			lookRotation = 50.0f;
		}
		else
			if (bird_rb.velocity.y < -75.0f) {
				lookRotation = -75.0f;
			}
		bird.transform.rotation = Quaternion.Euler (0.0f, 0.0f, lookRotation);
	}
}
