using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float _speed;

	void Update(){
		transform.Translate (Vector3.forward * _speed * Time.deltaTime);
	}

	public void SetSpeed(float value)
	{
		_speed = value;
	}
	void Start()
	{
		Destroy (gameObject, 2f);
	}

}
