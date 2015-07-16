using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemSpawn : MonoBehaviour {

	public List<GameObject> prefabs;
	public int spawnpoint;
	//Vector3 spawn1 = new Vector3 (-76.17963f,45.11432f,-48.49158);
	Vector3 spawn2 = new Vector3 (-29.46464f,45.11432f,-103.0663f);
	Vector3 spawn3 = new Vector3 (-143.6341f,45.11432f,4.864616f);
	Vector3 spawn4 = new Vector3 (9.057945f,45.11432f,-11.93123f);

	// Use this for initialization
	void Start () {
	
		spawnpoint = Random.Range(2, 5);
		
		//if (spawnpoint == 1)
		//{
			//Instantiate(prefabs[Random.Range(0, prefabs.Count)], spawn1, Quaternion.identity);
		//}
		
		if (spawnpoint == 2)
		{
			Instantiate(prefabs[Random.Range(0, prefabs.Count)], spawn2, Quaternion.identity);
		}
		
		if (spawnpoint == 3)
		{
			Instantiate(prefabs[Random.Range(0, prefabs.Count)], spawn3, Quaternion.identity);
		}
		
		if (spawnpoint == 4)
		{
			Instantiate(prefabs[Random.Range(0, prefabs.Count)], spawn4, Quaternion.identity);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
