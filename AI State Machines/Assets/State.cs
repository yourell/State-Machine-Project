using UnityEngine;
using System.Collections;

public abstract class State {

	protected GameObject myGameObject;
	public State(GameObject gameobject)
	{
		this.myGameObject = gameobject;
	}
	
	public abstract void Update ();
	public abstract void Enter ();
	public abstract void Exit ();
}
