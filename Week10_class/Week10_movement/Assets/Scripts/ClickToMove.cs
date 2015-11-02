using UnityEngine;
using System.Collections;

public class ClickToMove : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//check if player is clicking

		if (Input.GetMouseButton(0))
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit) && hit.collider.tag == "Ground")
			{

				Vector3 move;
				// get direction to destination

				// vector between destination and current location
				move = hit.point - transform.position;
				// set that vector's magnitude to 1
				move.Normalize();
				// move transform in that direction
				transform.position += move * Time.deltaTime * moveSpeed;

				//set the magnitude of the vector to 1;



				// THIS LERP MOVEMENT is okay for some stuff, but I want more control!
//				transform.position = Vector3.Lerp(transform.position, hit.point, .2f);
			}


		
			//transform.position = Input.mousePosition;
		}



		//move player toward click location

	}
}
