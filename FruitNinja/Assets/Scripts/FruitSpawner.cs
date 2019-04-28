using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour {

	public static GameObject fruitPrefab;

    public static float size;
    //public GameObject orangePrefab;
    //public GameObject melonPrefab;

    //public GameObject fruitSize;
	public Transform[] spawnPoints;

	public static float minDelay = .1f;
	public static float maxDelay = 1f;

    //public static float height, width;


	// Use this for initialization
	void Start () {
		StartCoroutine(SpawnFruits());
	}

	IEnumerator SpawnFruits ()
	{
		while (true)
		{
			float delay = Random.Range(minDelay, maxDelay);
			yield return new WaitForSeconds(delay);

			int spawnIndex = Random.Range(0, spawnPoints.Length);
			Transform spawnPoint = spawnPoints[spawnIndex];

			GameObject spawnedFruit = Instantiate(fruitPrefab, spawnPoint.position, spawnPoint.rotation);
            spawnedFruit.transform.localScale = new Vector3(size, size, 1);
            //width = spawnedFruit.GetComponent<SpriteRenderer>().sprite.rect.width;
            //height = spawnedFruit.GetComponent<SpriteRenderer>().sprite.rect.height;
            Destroy(spawnedFruit, 5f);
		}
	}
	
}
