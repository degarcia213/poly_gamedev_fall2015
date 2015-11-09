using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Player player;
	public Enemy basic;
	public Enemy fierce;
	public float spawnTime;
	public Transform[] spawnPoints;

	// Use this for initialization
	void Start () {
		InvokeRepeating("SpawnEnemy", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SpawnEnemy()
	{

		if (player.currentHealth <= 0)
		{
			return;
		}

		float random = Random.Range (0, 5);
		if (random < 1)
		{
			Enemy newEnemy = (Enemy) Instantiate(fierce, spawnPoints[Random.Range(0,spawnPoints.Length)].position, Quaternion.identity);
			newEnemy.target = player.transform;
		} else {
			Enemy newEnemy = (Enemy) Instantiate(basic, spawnPoints[Random.Range(0,spawnPoints.Length)].position, Quaternion.identity);
			newEnemy.target = player.transform;
		}
	}
}
