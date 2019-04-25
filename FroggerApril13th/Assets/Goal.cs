using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

	void OnTriggerEnter2D ()
	{
		Debug.Log("YOU WON!");
		Score.CurrentScore += 100;
        Score.TotalScore += 100;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
