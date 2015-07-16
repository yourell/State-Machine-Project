using UnityEngine;
using System.Collections;

public class DepressionGUI : MonoBehaviour {
	
	//this is the text that will be displayed
	//string TextToDisplay = "Find The Key";
	public int Depression = 0;
	
	void OnGUI()
	{
		//this is where the GUI code goes
		//this box should enclose the other GUI Elements
		//GUI.Box(new Rect(10, 10, 300, 90), "Depression");
		
		// this label will display different text
		//GUI.Label(new Rect(20, 30, 250, 70), Depression);
		GUILayout.Label( "Depression = " + Depression + "%");
	}
	
	void Update()
	{	
		// set TextToDisplay to newText
		//TextToDisplay = newText;
		
		//Depression ++;
	}
	
	void OmTriggerEnter(Collider other) {
		// If asteroid is hit by a bullet, destroy both
		// Spawn smaller asteroids and add to player score
		if (other.gameObject.tag == "Demon")
		{
			Depression ++;
		}
	}
	
	void OnTriggerStay(Collider other) {
		// If asteroid is hit by a bullet, destroy both
		// Spawn smaller asteroids and add to player score
		if (other.gameObject.tag == "Demon")
		{
			Depression ++;
		}
	}
}