using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public int maxHealth;
	public int currentHealth;

	public Bullet bullet;
	
	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {

		if (currentHealth <= 0)
		{
			gameObject.SetActive(false);
		}

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Shoot();
		}

	}

	void Shoot()
	{
		Bullet newBullet = (Bullet) Instantiate(bullet, transform.position + (transform.forward), transform.rotation);
		newBullet.dir = transform.forward;
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.other.tag == "Enemy")
		{
			currentHealth -= col.other.GetComponent<Enemy>().damage;
		}
	}
}