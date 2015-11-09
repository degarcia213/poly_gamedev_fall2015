using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public Vector3 dir;
	public int speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += dir * Time.deltaTime * speed;
	
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			col.gameObject.GetComponent<Enemy>().Kill();
			Destroy(gameObject);
		} else {
			Destroy(gameObject);
		}
	}
}
