using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class canvas : MonoBehaviour {

	public PlayerShooting ps;
	public Text ammotxt;
	// Use this for initialization
	void Start () {
		ps = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerShooting> ();
	}
	
	// Update is called once per frame
	void Update () {
		ammotxt.text = "Ammo: " + ps.ammo;
	}
}
