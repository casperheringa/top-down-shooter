using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour {

	public int health = 10;
	private NavMeshAgent navMeshAgent;
	private Transform playerObj;

	void Awake(){
		navMeshAgent = GetComponent<NavMeshAgent> ();
		playerObj = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	void Update(){
		navMeshAgent.SetDestination (playerObj.position);
		if (health <= 0) {
			Destroy (gameObject);
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("bullet")) 
		{
			Destroy (other.gameObject);
			health--;
			Debug.Log ("welloe");
		}
	}
}
