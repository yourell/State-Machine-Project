using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

	void OnTriggerEnter (Collider other)
 {
 if(other.tag == ("Player"))
 {
 

GameObject Gui = GameObject.FindWithTag ("GUI");
 Gui.BroadcastMessage("UpdateText","You have the key");
 
GameObject FPC = GameObject.FindWithTag ("Player");
 FPC.BroadcastMessage("GetKey");
 
Destroy(gameObject);
 
}
 }
}