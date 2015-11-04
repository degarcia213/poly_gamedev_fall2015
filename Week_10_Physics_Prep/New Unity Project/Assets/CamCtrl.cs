using UnityEngine;
using System.Collections;

public class CamCtrl : MonoBehaviour {

	public GameObject[] cams;
	public int currentCam = 0;

	// Use this for initialization
	void Start () {
		ActivateCamera(currentCam);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space))
		{
			ActivateCamera(currentCam+1);
		}
	}

	public void DeactivateAllCams()
	{
		//deactivate all cameras
		//iterate through the list of each camera
		for (int i = 0; i < cams.Length; i++)
		{
			//deactivate the one at position "i"
			cams[i].SetActive(false);
		}
	}

	public void ActivateCamera(int _camID)
	{
		//if the camera id is above the possible cams, set it back to the original.
		if (_camID >= cams.Length)
		{
			_camID = 0;
		}

		DeactivateAllCams();

		//activate the camera at the _camID position
		cams[_camID].SetActive(true);
		//set currentCam to that camera
		currentCam = _camID;
	}
}