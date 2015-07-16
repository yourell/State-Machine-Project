using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	
	NavMeshAgent myNMA;
	Transform player;
	public Transform[] waypoints;
	public float distance;
	public int x = 0;
	float waitTime;
	public float waitTimer;
	//public Transform[] waypoints;
	//public int x = 0;
	//float waitTime;
	//public float waitTimer;
	
	// Use this for initialization
	void Start () {
		myNMA = transform.GetComponent<NavMeshAgent>();
		player = GameObject.FindWithTag("Player").transform;
		
		//for (int i = 0; i < waypoints.Length; i++)
		//{
		//	waypoints[i] = GameObject.Find ("Waypoint" + i).transform;
		//}
		
		//for (int i = 0; i < waypoints.Length; i++)
		//{
		//	waypoints[i] = GameObject.Find ("Waypoint" + i).transform;
		//}
	}
	
	// Update is called once per frame
	void Update () {
		//myNMA.destination = player.position;
		distance = Vector3.Distance(player.transform.position, transform.position);
		myNMA.destination = waypoints[x].position;
		if (distance <= 10f)
		{
			myNMA.destination = player.position;
		}
		
		if (myNMA.remainingDistance < myNMA.stoppingDistance && myNMA.remainingDistance != 0)
		{
			waitTime += Time.deltaTime;
			if(waitTime >= waitTimer)
			{
				x = (x + 1) % waypoints.Length;;
				waitTime = 0;
			}
			/*if(x == waypoints.Length - 1)
			{
				x = 0;
			}
			else
			{
			x++;
			}*/
		}
		//myNMA.destination = waypoints[x].position;
		
		/*if (myNMA.remainingDistance < myNMA.stoppingDistance && myNMA.remainingDistance != 0)
	 {
	 	Application.LoadLevel(Application.loadedLevelName);
	 }*/
		
		/*if (myNMA.remainingDistance < myNMA.stoppingDistance && myNMA.remainingDistance != 0)
		{
			waitTime += Time.deltaTime;
			if(waitTime >= waitTimer)
			{
				x = (x + 1) % 4;
				waitTime = 0;
			}
			
		}*/
	}
}
