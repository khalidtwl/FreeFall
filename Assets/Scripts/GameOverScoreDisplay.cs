using UnityEngine;
using System.Collections;

public class GameOverScoreDisplay : MonoBehaviour 
{
	// object that displays text on UI
	public UnityEngine.UI.Text text;

	// Use this for initialization
	void Start () 
	{
		// displays score value
		text.text = "Score: " + PlayerPrefs.GetInt ("game score");
	}
}