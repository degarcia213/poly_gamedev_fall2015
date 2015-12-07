using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {
	

		if (Input.GetKey(KeyCode.W))
		{
			anim.SetBool("isWalking", true);
			transform.position += transform.forward;
		} else {

			anim.SetBool("isWalking", false);
		}

	}
}
