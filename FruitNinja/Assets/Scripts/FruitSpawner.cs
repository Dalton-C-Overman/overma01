using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FruitSpawner : MonoBehaviour {

	public static GameObject fruitPrefab;

    public static float gravity;
    public static float size;
    //public GameObject orangePrefab;
    //public GameObject melonPrefab;

    //public GameObject fruitSize;
	public Transform[] spawnPoints;

	public static float minDelay = .1f;
	public static float maxDelay = 1f;
    public static float time;
    //public static bool play = true;
    public GameObject replayButton;
    public GameObject quitButton;
    public Text timer;

    public static float gameScore;
    public static float gameMissed;
    //public static float height, width;


    //void startTimer()
    //{
        
    //}

	// Use this for initialization
	void Start () {
        Scorer.missed = 0;
        Scorer.total = 0;
        Scorer.score = 0;
        Physics.gravity = new Vector3(0, gravity, 0);
        StartCoroutine(SpawnFruits());
        replayButton.SetActive(false);
        quitButton.SetActive(false);
	}

    private float elapsedTime;
    private void Update()
    {
        elapsedTime += Time.deltaTime;
        timer.text = "Time Remaining: " + Mathf.CeilToInt(time - elapsedTime).ToString();
        if (time == 999f)
        {
            elapsedTime = 0f;
        }
        else
            if (elapsedTime >= time)
            stopGame();
                //play = false;
    }

    void stopGame()
    {
        //if (play == false)
        //{
        StopAllCoroutines();
        gameMissed = Scorer.missed;
        gameScore = Scorer.score;
        timer.text = "Time Remaining: 0";
        replayButton.SetActive(true);
        quitButton.SetActive(true);
        //}
    }

    void destroyFruit(GameObject spawnedFruit)
    {
        Scorer.updateTotal();
        Destroy(spawnedFruit, 5f);
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
            destroyFruit(spawnedFruit);
        }
	}
	
}
