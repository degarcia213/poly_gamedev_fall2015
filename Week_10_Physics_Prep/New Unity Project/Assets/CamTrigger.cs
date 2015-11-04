using UnityEngine;
using System.Collections;

public class CamTrigger : MonoBehaviour {

	public CamCtrl camCtrl;
	public GameObject camToActivate;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		camCtrl.DeactivateAllCams();
		camToActivate.SetActive(true);
	}
}
