using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	
	NavMeshAgent myNMA;
	Transform player;
	public Transform[] waypoints;
	public int waypointIndex = 0;
	float waitTime;
	
	// Use this for initialization
	void Start () 
	{
		myNMA = transform.GetComponent<NavMeshAgent>();
		player = GameObject.FindWithTag("Player").transform;
		
		for(int i = 0; i < waypoints.Length; i++)
		{
			waypoints[i] = GameObject.Find ("Waypoint "+i).transform;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		myNMA.destination = waypoints[waypointIndex].position;
		
		if (myNMA.remainingDistance < myNMA.stoppingDistance && myNMA.remainingDistance !=0)
		{
			waitTime += Time.deltaTime;
			if(waypointIndex == waypoints.Length-1)
			{
				waypointIndex = (waypointIndex +1) % 4;
				waitTime = 0;
			}
			else
			{//Application.LoadLevel(Application.loadedLevelName);
				waypointIndex ++;
			}
		}
	}
}


