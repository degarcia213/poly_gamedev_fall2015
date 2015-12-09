using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	
	public Image mapIndicator; 

	Animator anim;
	Vector2 relativePosition;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {
	

		if (Input.GetKey(KeyCode.W))
		{
			anim.SetBool("isWalking", true);
			transform.position += transform.forward * Time.deltaTime * 10;
		} else {

			anim.SetBool("isWalking", false);
		}

		if (Input.GetKey(KeyCode.A))
		{
			transform.RotateAround(transform.position, transform.up, -10);
		}

		Vector3 mapIndicatorPos = new Vector3(transform.localPosition.x, transform.localPosition.z, 0);
		mapIndicator.transform.localPosition = mapIndicatorPos * (100f/12.13f);
		Quaternion myRot = new Quaternion(transform.localRotation.x, transform.localRotation.z, -transform.localRotation.y, transform.localRotation.w);
		mapIndicator.transform.localRotation = myRot;
	}
}
