using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour 
{
	// initializes player positions
	float mouseX = Screen.width / 2;
	float mouseY = Screen.height / 2;

	// Update is called once per frame
	void Update () 
	{
		// obtains touch positions
		if (Input.touches.Length > 0) 
		{
			mouseX = Input.touches[0].position.x;
			mouseY = Input.touches[0].position.y;
			mouseX /= Screen.width;
			mouseY /= Screen.height;
		}

		// adjusts for scale of objects
		float newX = mouseX * 10.0f - 5f;
		float newZ = mouseY * 5.5f - 2.75f;

		// moves player
		transform.position = new Vector3(newX, 0, newZ);
	}
}
