using UnityEngine;
using System.Collections;

public class ControllerScript : MonoBehaviour 
{
	public int score = 0;
	public UnityEngine.UI.Text text;

	// Use this for initialization
	void Start () 
	{
		score = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		text.text = "Score: " + score;
	}

	// Ends game
	public void GameOver() 
	{
		// sets up integer to use in UI
		PlayerPrefs.SetInt ("game score", score);

		// loads Game Over screen
		Application.LoadLevel ("GameOverScene");
	}
}
