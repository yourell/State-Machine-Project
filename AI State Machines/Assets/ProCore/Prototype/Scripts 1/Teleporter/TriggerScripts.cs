using UnityEngine;
using System.Collections;

public class TriggerScripts : MonoBehaviour {
	
	public GameObject theGUI;
	
	void OnTriggerEnter(Collider thingThatEntered)
	{ 	
		theGUI = GameObject.FindWithTag ("GUI");
		theGUI.BroadcastMessage("UpdateText", "HEY");
	}
}
