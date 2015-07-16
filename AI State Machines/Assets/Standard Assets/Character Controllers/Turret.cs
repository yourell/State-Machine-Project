using UnityEngine;
using System.Collections;

public class Turret : MonoBehaviour {

	enum States
	{
		Initilize,
		Idle,
		Attack,
		Search,
	}
	
	States currentState = States.Initilize;
	
	Transform player;
	Ray ray;
	RaycastHit hit;
	float randLookTime, randLookTimer = 0.3f;
	float searchPosition, searchTime, searchTimer;
	
	
	// Update is called once per frame
	void Update () 
	{
		switch(currentState)
		{
			case States.Initilize:
			Initilize();
			break;
			case States.Idle:
			Idle();
			break;
			case States.Attack:
			Attack();
			break;
			case States.Search:
			//			Search();
			break;	
		}
		Debug.DrawRay(transform.position, transform.forward*10f, Color.magenta);
	}

	void Initilize()
	{
		player = GameObject.FindWithTag("Player").transform;
		currentState = States.Idle;
	}

	void Idle()
	{
		ray =new Ray(transform.position, transform.forward);
		if(Physics.Raycast(ray, out hit, 10f))
		{
			if(hit.collider.tag == "Player")
			{
				currentState = States.Attack;
			}
		}

	}
	
	void Attack()
	{
		Vector3 lookatPlayer = new Vector3(player.position.x, player.position.y, player.position.z);
		transform.LookAt(lookatPlayer);
		if(Vector3.Distance(transform.position, player.position) > 10f)
		{
			currentState = States.Search;
		}
	}

	//void Search()
	//{
	//	randLookTime += Time.deltaTime;
	//	if(randLookTime >= randLookTimer)
	//	{
	//		Vector3 randLookPosition = new Vector3(transform.position.x + Random.Range (-7, 7), player.transform.position, player.transform.position);
	//		transform.LookAt(randLookPosition);
	//		randLookTime = 0;
	//	}
	//	searchTime += Time.deltaTime;
	//	if(searchPosition >= searchTimer)
	//	{
	//		currentState = States.Idle
	//	}
	//	}
}
