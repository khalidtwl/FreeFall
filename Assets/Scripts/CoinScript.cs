using UnityEngine;
using System.Collections;

public class CoinScript : MonoBehaviour 
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
		// Rotates obstacles
		transform.Rotate (new Vector3(5, 0, 0));
	
	}
	
	void OnCollisionEnter(Collision coll)
	{
		// Checks who has collided
		if (coll.gameObject.name.Equals ("Main Player")) 
		{
			// Increments score
			mainController.score++;
			// Removes
			transform.position = new Vector3 (40, 0, 40);
		}
	
	}
}