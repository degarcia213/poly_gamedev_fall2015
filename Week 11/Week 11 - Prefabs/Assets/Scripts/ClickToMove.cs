﻿using UnityEngine;
using System.Collections;

public class ClickToMove : MonoBehaviour {
	
	private float hitDist = 0;
	private Vector3 destination;

	public float moveSpeed;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetMouseButton(0))
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Ground")
			{
				destination = hit.point;
				destination += Vector3.up * .5f;

				Vector3 lookPos = destination - transform.position;
				lookPos.y = 0;

				transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(lookPos), .2f);
				//transform.rotation = new Quaternion(0, transform.rotation.y, 0, 0);


				// this is the lerp version. It works, but what if I want something more consistent?
				//transform.position = Vector3.Lerp(transform.position, destination, .2f);

				Vector3 moveDir = destination - transform.position;

				moveDir.Normalize();

				transform.position += moveDir * Time.deltaTime * moveSpeed;
			}
		}
	}
}