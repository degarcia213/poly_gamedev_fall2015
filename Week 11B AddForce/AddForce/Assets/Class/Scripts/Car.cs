using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {

	private Rigidbody rb;
	public float driveSpeed;
	public float jumpStrength;

	public bool grounded = false;

	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.A))
		{
			transform.RotateAround(transform.position, transform.up, -5);
		}
		if (Input.GetKey (KeyCode.D))
		{
			transform.RotateAround(transform.position, transform.up, 5);
		}
	
	}

	void OnCollisionStay(Collision col)
	{
		if (col.collider.tag == "Ground")
		{
			grounded = true;
		}
	}

	void OnCollisionExit(Collision col)
	{
		if (col.collider.tag == "Ground")
		{
			grounded = false;
		}
	}

	//FixedUpdate is called once per physics step
	void FixedUpdate()
	{

		if (Input.GetKeyDown(KeyCode.Space))
		{
			if (grounded)
			{
				rb.AddForce(transform.up * jumpStrength, ForceMode.VelocityChange);
			}
		}

		if (Input.GetKey(KeyCode.W))
		{
			//normally we'd just move the transform
			//transform.position += transform.forward

			//instead we're going add a force to our rigid body
			rb.AddForce(transform.forward * driveSpeed);
		}
	}
}
