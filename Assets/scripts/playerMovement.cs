using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	public float speed = 5;
	private Vector3 movement;
	private Rigidbody rb;
	private float xInput;
	private float yInput;

	void Awake () {
		rb = this.GetComponent<Rigidbody> ();
	}

	void Update () {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		Plane plane = new Plane (Vector3.up, Vector3.zero);
		float distance;
		if (plane.Raycast (ray, out distance)) {
			Vector3 point = ray.GetPoint (distance);
			Vector3 adjustedHeightPoint = new Vector3 (point.x, transform.position.y, point.z);
			transform.LookAt (adjustedHeightPoint);
		}

		xInput = Input.GetAxis ("Horizontal");
		yInput = Input.GetAxis ("Vertical");

		Vector3 Movement = new Vector3 (xInput, 0.0f, yInput);
		transform.position += Movement * speed * Time.deltaTime;
	}		
}
