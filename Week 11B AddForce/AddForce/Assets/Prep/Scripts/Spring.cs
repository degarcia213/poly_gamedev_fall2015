using UnityEngine;
using System.Collections;

public class Spring : MonoBehaviour {

	public float springForce;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col)
	{
		col.collider.attachedRigidbody.AddForce(Vector3.up * springForce);
	}
}
