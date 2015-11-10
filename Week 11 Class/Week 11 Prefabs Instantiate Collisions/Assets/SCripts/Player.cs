using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


	public Bullet bullet;
	public int maxHealth;
	public int currentHealth;

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {

		//if the player's health is zero, deactivate the player
		if (currentHealth <= 0)
		{
			gameObject.SetActive(false);
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Shoot();
		}
	
	}

	//if the enemy hits the player, the player loses health
	void OnCollisionEnter(Collision col){
		//decrease the health if the collider's tag tells us it's an 'enemy'. We set the tag in the inspector underneath the object name.
		if (col.collider.tag == "Enemy")
		{
			currentHealth -= 1;
		}

	}

	void Shoot()
	{
		//instatiate a bullet and set it to newBullet
		Bullet newBullet = (Bullet)Instantiate(bullet, transform.position + transform.forward, Quaternion.identity);
		// set the direction variable of newBullet to the direction the player's facing.
		newBullet.direction = transform.forward;
	}

}
