using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class HighScores : MonoBehaviour {

    private static string defaultPath = "Assets/PlayerData/HighScores.txt";
    private string[] nameData = new string [6];
    private string[] scoreData = new string[6];
    string[] newLineDelim;
    List<string> commaDelim = new List<string>();

    private string sceneName;
    public Text playerName, misses, hits;

    public Text highScoreText;

	// Use this for initialization
	void Start () {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        readHighScores();
        playerName.text = InsertPlayerName.ConstantName;
        misses.text = FruitSpawner.gameMissed.ToString();
        hits.text = FruitSpawner.gameScore.ToString();
    }

    public void readHighScores()
    {
        loadData();
        if (OptionsMain.eligible && sceneName == "End")
        {
            updateHighScores();
            writeHighScores();
            writePlayerScore();
        }

        highScoreText.text = "High Scores: \n" + nameData[0] + " " + scoreData[0] + "\n" +
                              nameData[1] + " " + scoreData[1] + "\n" +
                              nameData[2] + " " + scoreData[2] + "\n" +
                              nameData[3] + " " + scoreData[3] + "\n" +
                              nameData[4] + " " + scoreData[4];
    }

    void writePlayerScore()
    {
        StreamWriter writer = new StreamWriter("Assets/PlayerData/" + InsertPlayerName.ConstantName + ".txt");
        writer.WriteLine(InsertPlayerName.ConstantName);
        writer.WriteLine(FruitSpawner.gameScore.ToString());
        writer.WriteLine(InsertPlayerName.score1);
        writer.WriteLine(InsertPlayerName.score2);
        writer.Close();
    }

    void loadData()
    {
        StreamReader sr = new StreamReader(defaultPath);
        string rawData = sr.ReadToEnd();
        sr.Close();
        string[] newLineDelim = rawData.Split('\n');

        foreach (string c in newLineDelim)
        {
            commaDelim.AddRange(c.Split(','));
            //Debug.Log(s);
        }
        //foreach (string s2 in commaDelim)
            //Debug.Log("s2: " + s2);

        //for (int i = 0; i < 10; i++)


        int k1 = 0;
        int k2 = 0;
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
            if (i == 0 || i % 2 == 0)
            {
                nameData[k1] = commaDelim[i];
                k1++;
            }
            else
            {
                scoreData[k2] = commaDelim[i];
                k2++;
            }
        }
    }

    void updateHighScores()
    {

        scoreData[5] = FruitSpawner.gameScore.ToString();
        nameData[5] = InsertPlayerName.ConstantName;


        for (int i = 0; i < scoreData.Length - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (int.Parse(scoreData[j - 1]) < int.Parse(scoreData[j]))
                {
                    string temp = scoreData[j - 1];
                    scoreData[j - 1] = scoreData[j];
                    scoreData[j] = temp;

                    temp = nameData[j - 1];
                    nameData[j - 1] = nameData[j];
                    nameData[j] = temp;
                }
            }
        }


    }

    void writeHighScores()
    {
        StreamWriter sw = new StreamWriter(defaultPath);
        sw.WriteLine(nameData[0] + "," + scoreData[0]);
        sw.WriteLine(nameData[1] + "," + scoreData[1]);
        sw.WriteLine(nameData[2] + "," + scoreData[2]);
        sw.WriteLine(nameData[3] + "," + scoreData[3]);
        sw.WriteLine(nameData[4] + "," + scoreData[4]);

        sw.Close();
    }
}
