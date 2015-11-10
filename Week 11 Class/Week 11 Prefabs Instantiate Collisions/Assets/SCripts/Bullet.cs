using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public Vector3 direction;
	public float speed;

	// Use this for initialization
	void Start () {
		// make the bullet destroy itself after 5 seconds
		Destroy(gameObject, 5.0f);
	}
	
	// Update is called once per frame
	void Update () {
		//move in a direction fast
		transform.position += direction * Time.deltaTime * speed;
	}

	void OnCollisionEnter(Collision col)
	{
		//test hit
		Debug.Log("Bullet Hit");

		//get rid of enemies
		//check if it's an enemy
		if(col.collider.tag == "Enemy")
		{
		//set enemy to inactive
			col.collider.gameObject.SetActive(false);
			Destroy(gameObject);
		}

	}
}
