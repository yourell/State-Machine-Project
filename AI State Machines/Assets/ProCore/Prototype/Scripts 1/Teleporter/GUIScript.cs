using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {

	//this is the text that will be displayed
	string TextToDisplay = "Find The Key";
	
	void OnGUI()
	{
		//this is where the GUI code goes
		//this box should enclose the other GUI Elements
		GUI.Box(new Rect(10, 10, 300, 90), "HUD");
		
		// this label will display different text
		GUI.Label(new Rect(20, 30, 250, 70), TextToDisplay);
	}
	
	void UpdateText( string newText )
	{	
		// set TextToDisplay to newText
		TextToDisplay = newText;

	}
}