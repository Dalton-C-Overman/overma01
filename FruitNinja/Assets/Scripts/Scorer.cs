using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Scorer : MonoBehaviour {

    public static float score = 0;
    public Text scoreText;
    public static float total = 0;
    public static float missed = 0;
    public Text missedText;
    public Text totalText;
    public static float destroyed = 0;
    public static float onScreen = 0;
    public Text onScreenText;

    private GameObject[] getOnScreen;

    private void Update()
    {
        getOnScreen = GameObject.FindGameObjectsWithTag("Fruit");
        onScreen = getOnScreen.Length;
        missed = (total - onScreen) - score;
        onScreenText.text = "On Screen: " + onScreen.ToString();
        totalText.text = "Total: " + total.ToString();
        scoreText.text = "Hit: " + score.ToString();
        missedText.text = "Missed: " + missed.ToString();
    }
    public static void updateScore()
    {
        score += 1;
    }
    public static void updateTotal()
    {
        total += 1;
    }
    public static void updateDestroyed()
    {
        destroyed += 1;
    }
}
