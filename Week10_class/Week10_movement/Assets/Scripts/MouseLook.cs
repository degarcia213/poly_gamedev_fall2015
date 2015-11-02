using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {

	public float lookSensitivity;
	public float ySensitivity; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		// check if player drags mouse

		if (Input.GetAxis("Mouse X") > 1 || Input.GetAxis("Mouse X") < -1)
		{
			//rotate player in direction of mouse
			transform.Rotate(transform.up, Input.GetAxis("Mouse X") * lookSensitivity);
		}

		if (Input.GetAxis("Mouse Y") > 1 || Input.GetAxis("Mouse Y") < -1)
		{
			//rotate player in direction of mouse
			transform.Rotate(transform.right, Input.GetAxis("Mouse Y") * ySensitivity);
		}


	
	}
}
