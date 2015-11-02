using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {

	public float turnSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		float mouseRot = Input.GetAxis("Mouse X");
		
		if (mouseRot > .5)
		{
			transform.Rotate(Vector3.up, mouseRot * turnSpeed);
		} else if (mouseRot < -.5)
		{
			transform.Rotate (Vector3.up, mouseRot * turnSpeed);
		}

	}
}
