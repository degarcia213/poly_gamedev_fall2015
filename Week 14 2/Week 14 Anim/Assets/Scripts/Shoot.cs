using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public ParticleSystem ptcl;

	// Use this for initialization
	void Start () {

		ptcl = GetComponent<ParticleSystem>();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space))
		{
			ptcl.Emit(100);
		}
	
	}
}
