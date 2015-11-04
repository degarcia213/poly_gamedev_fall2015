using UnityEngine;
using System.Collections;

public class CamControl : MonoBehaviour {

	public GameObject[] cams;
	private int currentCam = 0;

	// Use this for initialization
	void Start () {

		ActivateCam(currentCam);
	}
	
	// Update is called once per frame
	void Update () {

		//detect key press
		if (Input.GetKeyDown(KeyCode.Space)){
			//move to the next camera
			currentCam += 1;
			if (currentCam == cams.Length)
			{
				currentCam = 0;
			}
			ActivateCam(currentCam);
		}
	
	}

	public void DeactivateAllCams()
	{
		//deactivate all cameras
		for (int i = 0; i < cams.Length; i++)
		{
			cams[i].SetActive(false);
			cams[i].transform.FindChild("bg").gameObject.SetActive(false);
		}
	}

	public void ActivateCam(int camIndex){

		DeactivateAllCams();

		//activate camindex cam
		cams[camIndex].SetActive(true);
		cams[camIndex].transform.FindChild("bg").gameObject.SetActive(true);

	}


}
