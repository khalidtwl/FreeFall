using UnityEngine;
using System.Collections;

public class StageScript : MonoBehaviour 
{
	float speed = 10;
	public GameObject[] pieces;

	// Use this for initialization
	void Start () 
	{
		ResetPieces ();
		speed = 10;
	}
	
	// Update is called once per frame
	void Update () 
	{
		speed += .01f;

		// changes the positions of objects
		transform.position = new Vector3 (transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);

		// checks if object is out of view
		if (transform.position.y > 20) 
		{
			transform.position = new Vector3 (transform.position.x, transform.position.y - 100f, transform.position.z);
			ResetPieces();
		}
	}

	// Handles moving all game objects besides player
	void ResetPieces()
	{
		foreach (GameObject piece in pieces) 
		{
			// Randomizes object locations
			float pieceY = Random.Range (-10f, -18f);	
			float pieceX = Random.Range (-4.5f, 4.5f);
			float pieceZ = Random.Range (-2.5f, 2.5f);
			piece.transform.localPosition = new Vector3(pieceX, pieceY, pieceZ);
		}
	}
}