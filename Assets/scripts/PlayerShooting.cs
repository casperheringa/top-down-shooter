using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerShooting : MonoBehaviour {

	public Bullet projectile;
	public Transform muzzle;
	public float bulletSpeed;
	public float delayTime;
	float delayCounter;
	public int ammo = 13;
	public Text uitext;


	void Update(){
		if(Input.GetKeyDown(KeyCode.R)){
			ammo = 13;
		}
		delayCounter -= Time.deltaTime;
		if (ammo == 0) {
			Debug.Log("op");
		}
		else if (Input.GetMouseButton(0)&& delayCounter < 0) 
		{
			Shoot ();
			ammo--;
			delayCounter = delayTime;
	
		}
	}
	private void Shoot()
	{
		Bullet bullet = Instantiate (projectile, muzzle.position, muzzle.rotation) as Bullet;
		bullet.SetSpeed (bulletSpeed);
	}
}
