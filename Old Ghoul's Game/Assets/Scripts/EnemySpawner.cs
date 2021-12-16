using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	public GameObject Enemy;
	Vector2 whereToSpawn;
	public float spawnRate = Random.Range(2f, 5f);
	float nextSpawn = 0.0f;

	void Update()
	{
		transform.Translate(4f * Time.deltaTime, 0, 0);
		if (Time.time > nextSpawn)
        {
			nextSpawn = Time.time + spawnRate;
			whereToSpawn = new Vector2(transform.position.x, transform.position.y);
			Instantiate(Enemy, whereToSpawn, Quaternion.identity);
        }
	}
}