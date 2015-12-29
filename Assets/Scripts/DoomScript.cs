using UnityEngine;
using System.Collections;

public class DoomScript : MonoBehaviour 
{
	ControllerScript mainController;

	// Use this for initialization
	void Start () 
	{
		// Creates an object that can use functions in ControllerScript
		mainController = GameObject.Find ("GameController").GetComponent<ControllerScript>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (new Vector3(5, 5, 5));
	}

	// In the event of a collision
	void OnCollisionEnter(Collision coll)
	{
		// Checks if player was the collider
		if (coll.gameObject.name.Equals ("Main Player")) 
		{
			mainController.GameOver ();
		}
	}
}