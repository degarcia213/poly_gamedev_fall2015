using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour {

	public GameObject loadingImage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadScene(string _scene)
	{
		if(loadingImage != null){
		loadingImage.SetActive(true);
		}
		Application.LoadLevel(_scene);
	}
}
