using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static int CurrentScore = 0;
    public static int TotalScore = 0;

    public Text scoreText;
    public Text totalScoreText;

    void Start ()
	{
		scoreText.text = CurrentScore.ToString();
        totalScoreText.text = TotalScore.ToString();
	}

}
