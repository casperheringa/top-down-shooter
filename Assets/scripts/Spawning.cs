using UnityEngine;
using System.Collections;

public class Spawning : MonoBehaviour {

	public GameObject enemyg;
	public Transform spawnpos;
	float nextSpawnTime;
	public float spawnrate;

	void Start () {
		GameObject enemy = Instantiate (enemyg, spawnpos.position, spawnpos.rotation) as GameObject;

	}
	
	void Update () {
		if (Time.time >= nextSpawnTime) {
			GameObject enemy = Instantiate (enemyg, spawnpos.position, spawnpos.rotation) as GameObject;
			nextSpawnTime = Time.time + spawnrate;

		}
	}
}
