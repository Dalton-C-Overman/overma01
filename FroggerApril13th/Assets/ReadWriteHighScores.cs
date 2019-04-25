using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class ReadWriteHighScores : MonoBehaviour
{

    public Text highScore1, highScore2, highScore3, highScore4, highScore5;
    public Text nameHighScore1, nameHighScore2, nameHighScore3, nameHighScore4, nameHighScore5;
    public Text name, score, lives;

    private static string defaultPath = "Assets/PlayerData/HighScores.txt";
    private string[] ReadHighScores;
    private string[] WriteHighScores;

    public void Start()
    {
        writeScores();
    }

    public void Update()
    {
        readScores();
        name.text = InsertPlayerName.ConstantName;
        score.text = Score.TotalScore.ToString();
        lives.text = Frog.livesUsed.ToString();
        //Debug.Log(ReadHighScores[0].ToString());
    }

    public void readScores()
    {
        StreamReader reader = new StreamReader(defaultPath);
        //if ((data = reader.ReadLine()) == null)
        //    AddPlayerName();
        ReadHighScores = new string[10];
        string line;
        int i = 0;
        while ((line = reader.ReadLine()) != null)
        {
            ReadHighScores[i] = line;
            i++;
        }

        nameHighScore1.text = ReadHighScores[0].ToString();
        highScore1.text = ReadHighScores[1].ToString();
        nameHighScore2.text = ReadHighScores[2].ToString();
        highScore2.text = ReadHighScores[3].ToString();
        nameHighScore3.text = ReadHighScores[4].ToString();
        highScore3.text = ReadHighScores[5].ToString();
        nameHighScore4.text = ReadHighScores[6].ToString();
        highScore4.text = ReadHighScores[7].ToString();
        nameHighScore5.text = ReadHighScores[8].ToString();
        highScore5.text = ReadHighScores[9].ToString();
    }

    public void writeScores()
    {
        
        StreamReader reader = new StreamReader(defaultPath);
        WriteHighScores = new string[10];
        string line;
        int e = 0;
        while ((line = reader.ReadLine()) != null)
        {
            WriteHighScores[e] = line;
            e++;
        }

        double comp1 = double.Parse(ReadHighScores[9]), comp2 = double.Parse(ReadHighScores[7]), comp3 = double.Parse(ReadHighScores[5]), comp4 = double.Parse(ReadHighScores[3]), comp5 = double.Parse(ReadHighScores[1]);
        if (Score.TotalScore > comp1 && Score.TotalScore <= comp2)
        {
            ReadHighScores[9] = Score.TotalScore.ToString();
            ReadHighScores[8] = InsertPlayerName.ConstantName;
        }
        else
        {
            ReadHighScores[9] = null;
            ReadHighScores[8] = null;
            if (Score.TotalScore > comp2 && Score.TotalScore <= comp3)
            {
                ReadHighScores[9] = ReadHighScores[7];
                ReadHighScores[8] = ReadHighScores[6];
                ReadHighScores[7] = Score.TotalScore.ToString();
                ReadHighScores[6] = InsertPlayerName.ConstantName;
            }
            else if (Score.TotalScore > comp3 && Score.TotalScore <= comp4)
            {
                ReadHighScores[9] = ReadHighScores[7];
                ReadHighScores[8] = ReadHighScores[6];
                ReadHighScores[7] = ReadHighScores[5];
                ReadHighScores[6] = ReadHighScores[4];
                ReadHighScores[5] = Score.TotalScore.ToString();
                ReadHighScores[4] = InsertPlayerName.ConstantName;
            }
            else if (Score.TotalScore > comp4 && Score.TotalScore <= comp5)
            {
                ReadHighScores[9] = ReadHighScores[7];
                ReadHighScores[8] = ReadHighScores[6];
                ReadHighScores[7] = ReadHighScores[5];
                ReadHighScores[6] = ReadHighScores[4];
                ReadHighScores[5] = ReadHighScores[3];
                ReadHighScores[4] = ReadHighScores[2];
                ReadHighScores[3] = Score.TotalScore.ToString();
                ReadHighScores[2] = InsertPlayerName.ConstantName;
            }
            else if (Score.TotalScore > comp5)
            {
                ReadHighScores[9] = ReadHighScores[7];
                ReadHighScores[8] = ReadHighScores[6];
                ReadHighScores[7] = ReadHighScores[5];
                ReadHighScores[6] = ReadHighScores[4];
                ReadHighScores[5] = ReadHighScores[3];
                ReadHighScores[4] = ReadHighScores[2];
                ReadHighScores[3] = ReadHighScores[1];
                ReadHighScores[2] = ReadHighScores[0];
                ReadHighScores[1] = Score.TotalScore.ToString();
                ReadHighScores[0] = InsertPlayerName.ConstantName;
            }
        }

        StreamWriter writer = new StreamWriter(defaultPath);
        for (int i = 0; i < 10; i++)
        {
            writer.WriteLine(ReadHighScores[i]);
        }
        writer.Close();
    }
}