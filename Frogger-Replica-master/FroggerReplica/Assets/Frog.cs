using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Frog : MonoBehaviour {

	public Rigidbody2D rb;
    public Text highScore1;
    //public Text highScore2;
   // public Text highScore3;
   // public Text highScore4;
    //public Text highScore5;

    void Start()
    {
        highScore1.text = PlayerPrefs.GetInt("HighScore1", 0).ToString();
       // highScore2.text = PlayerPrefs.GetInt("HighScore2", 0).ToString();
       // highScore3.text = PlayerPrefs.GetInt("HighScore3", 0).ToString();
       // highScore4.text = PlayerPrefs.GetInt("HighScore4", 0).ToString();
       // highScore5.text = PlayerPrefs.GetInt("HighScore5", 0).ToString();
    }

    void Update () {

		if (Input.GetKeyDown(KeyCode.RightArrow))
			rb.MovePosition(rb.position + Vector2.right);
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
			rb.MovePosition(rb.position + Vector2.left);
		else if (Input.GetKeyDown(KeyCode.UpArrow))
			rb.MovePosition(rb.position + Vector2.up);
		else if (Input.GetKeyDown(KeyCode.DownArrow))
			rb.MovePosition(rb.position + Vector2.down);

	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Car")
		{
			Debug.Log("WE LOST!");
            if (Score.CurrentScore > PlayerPrefs.GetInt("HighScore1", 0))
            {
                PlayerPrefs.SetInt("HighScore1", Score.CurrentScore);
            }
           // else if (Score.CurrentScore > PlayerPrefs.GetInt("HighScore2", 0))
           // {
           //     PlayerPrefs.SetInt("HighScore2", Score.CurrentScore);
           // }
           // else if (Score.CurrentScore > PlayerPrefs.GetInt("HighScore3", 0))
           // {
           //     PlayerPrefs.SetInt("HighScore3", Score.CurrentScore);
           // }
           // else if (Score.CurrentScore > PlayerPrefs.GetInt("HighScore4", 0))
           // {
           //     PlayerPrefs.SetInt("HighScore4", Score.CurrentScore);
           // }
           //  else if (Score.CurrentScore > PlayerPrefs.GetInt("HighScore5", 0))
           // {
           //     PlayerPrefs.SetInt("HighScore5", Score.CurrentScore);
           // }
            Score.CurrentScore = 0;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
