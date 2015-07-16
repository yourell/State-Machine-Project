using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {
public Transform destination; 

void OnTriggerEnter(Collider other)
{
if (other.tag == "Player") 
{

if(other.GetComponent<PlayerInventory>().HasKey == true) 
{
other.transform.position = destination.transform.position;

/*GameObject Gui = GameObject.FindWithTag("GUI"); //accesing the Gui gameObject and its attached Gui script
Gui.BroadcastMessage("UpdateText", "Congratulations! You Teleported Yourself!");
}
else {
GameObject Gui = GameObject.FindWithTag("GUI");
Gui.BroadcastMessage("UpdateText", "You need to find the Key to work the Teleporter, I think I left it at the back somewhere"); 
*/}
}
}
}