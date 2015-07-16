using UnityEngine;
using System.Collections;

public class ItemPickup : MonoBehaviour {

	//bool hasBluekey;
	public int hasItem;
	public LayerMask enemies;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Interact();
		Destroy();
		
		if(Input.GetKeyDown (KeyCode.Q) && hasItem > 0)
		{
			hasItem--;
			print ("Die demon");
			Invoke ("Explode", 1f);
		}
	}
	
	void Explode () {
		
		Collider[] hitThings = Physics.OverlapSphere(transform.position, 10f, enemies);
		
		for (int i = 0; i < hitThings.Length; i++)
		{
			if (hitThings[i].tag == "Demon")
			{print ("yyyyyn");
				Destroy(hitThings[i].gameObject);
				/*Vector3 forceDir = hitThings[i].transform.position - this.transform.position;
			forceDir.Normalize();
			hitThings[i].rigidbody.AddForce(forceDir * 800f + Vector3.up * 400f);*/
			}
			
		}
		
		//Destroy(this.gameObject);
		
	}
	
	
	
	void Interact(){
		
		if(Input.GetKeyDown (KeyCode.E))
		{
			
			RaycastHit hit; 
			if(Physics.Raycast(transform.position, transform.forward, out hit, 3f)){
				
				/*if(hit.collider.GetComponent<KeyCards>() != null){
					
					if(hit.collider.GetComponent<KeyCards>().whatColourAmI == KeyCards.Keycolours.blueKey){
						hasBluekey = true;
						Destroy(hit.collider.gameObject);
					}
					
					if(hit.collider.GetComponent<KeyCards>().whatColourAmI == KeyCards.Keycolours.redKey){
						hasRedkey = true;
						Destroy(hit.collider.gameObject);
					}
				}*/
				
				if(hit.collider.tag == "Item"){
					
					//if(hasRedkey){
						Destroy(hit.collider.gameObject);
						hasItem++;
					//}
					//else{
						print ("Found item");
					//}
				}
				
				/*if(hit.collider.name == "DoorBlue"){
					
					if(hasBluekey){
						Destroy(hit.collider.gameObject);
					}
					else{
						print ("Go find key");
					}
				}*/
				
			}
		}
	}
	void Destroy(){
		if(Input.GetKeyDown (KeyCode.F) && hasItem > 0){
			print ("Go find key");
			hasItem--;
			
		}
	}
}