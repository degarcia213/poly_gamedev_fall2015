using UnityEngine;
using System.Collections;

public class Windtunnel : MonoBehaviour {

	public float windSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay(Collider other)
	{
		if (other.GetComponent<Rigidbody>())
		{
			other.GetComponent<Rigidbody>().AddForce(transform.right * windSpeed);
			Debug.Log("whoosh");
		}
	}
}
