using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Transform target;
	public float moveSpeed;
	public int damage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//turn to face target
		transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), .2f);

		transform.position += transform.forward * Time.deltaTime * moveSpeed;

		//move toward target
	
	}

	public void Kill()
	{
		gameObject.SetActive(false);
	}
}
