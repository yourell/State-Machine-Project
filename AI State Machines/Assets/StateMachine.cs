﻿using UnityEngine;
using System.Collections;

public class StateMachine : MonoBehaviour {

	State currentState;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(currentState != null)
		{
			currentState.Update();
		}
	}
	public void SwitchState(State newState)
	{
		if(currentState != null)
		{
			currentState.Exit();
		}
		
		currentState = newState;
		if(newState != null)
		{
			currentState.Enter ();
		}
		
	}

}
