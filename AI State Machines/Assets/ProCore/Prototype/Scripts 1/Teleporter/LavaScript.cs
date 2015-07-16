using UnityEngine;
using System.Collections;

public class LavaScript : MonoBehaviour {

	public GameObject player;
	
	void OnTriggerEnter (Collider other)
	{
		Destroy (player);
	}
}
