using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public float jumpStrength;
	private float yVel;
	public float gravity;
	private bool grounded;

	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {
	
		if (transform.position.y > .5)
		{
			yVel += gravity * Time.deltaTime;
			grounded = false;
		} else {

			Vector3 groundedPos = new Vector3(transform.position.x, .5f, transform.position.z);
			transform.position = groundedPos;
			yVel = 0;
			grounded = true;
		}


		if (Input.GetKeyDown(KeyCode.Space) && grounded)
		{
			yVel = jumpStrength;
		}

		Vector3 newSpeed = new Vector3(0,yVel,0);
		transform.position += newSpeed * Time.deltaTime;

	}
}
