using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Player player;
	public Enemy basicEnemy;
	public Enemy fierceEnemy;
	public Transform[] spawnPoints;

	// Use this for initialization
	void Start () {
		// call the SpawnEnemy function once every second afer 1 second.
		InvokeRepeating("SpawnEnemy", 1f, 1f);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SpawnEnemy()
	{

		// we could randomize fierce vs. basic

		//instantiate new enemy
		Enemy newEnemy = (Enemy) Instantiate(basicEnemy, spawnPoints[Random.Range (0, spawnPoints.Length)].position, Quaternion.identity);
		//set enemy's target to player
		newEnemy.target = player.transform;
		//activating my game objects, for some reason they're deactivated!!!
		newEnemy.gameObject.SetActive(true);

	}
}
