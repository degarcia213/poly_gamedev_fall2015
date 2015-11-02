using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Get Input
		//Move Player

		if (Input.GetKey(KeyCode.W))
		{
			GetComponent<Transform>().position += (transform.forward * Time.deltaTime) * speed;
		}
		if (Input.GetKey (KeyCode.S))
		{
			transform.position += (-transform.forward * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.A))
		{
			transform.position += (-transform.right * Time.deltaTime * speed);
		}
		if (Input.GetKey (KeyCode.D))
		{
			transform.position += (transform.right * Time.deltaTime * speed);
		}


		//so now let's try mouse looking


	
	}
}
