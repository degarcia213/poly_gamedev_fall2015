using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public Transform target;
	public float moveSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// turn to face the player
		transform.rotation = Quaternion.LookRotation(target.position - transform.position);

		/// here's a slower, lerp version!
		//transform.rotation = Quaternion.Lerp (transform.rotation, Quaternion.LookRotation(target.position - transform.position), .2f);

		// move toward the player
		transform.position += transform.forward * moveSpeed * Time.deltaTime;
	
	}
}
