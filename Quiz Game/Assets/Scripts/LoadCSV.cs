using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class LoadCSV : MonoBehaviour
{
    internal static string[,] array;
    internal static string[] question;
    internal static string[] answer;

    void Start()
    {
        ReadCSVFile();
        LoadQuestions();
        LoadAnswers();
        Debug.Log(array[10, 4]);
        Debug.Log(question[0]);
        Debug.Log(question[42]);
        Debug.Log(question[59]);
        Debug.Log(question[37]);
        Debug.Log(answer[0]);
        Debug.Log(answer[16]);
        Debug.Log(answer[24]);
        Debug.Log(answer[59]);
    }

    void ReadCSVFile()
    {
        StreamReader strReader = new StreamReader("questionData.csv");
        bool endOfFile = false;

        array = new String[11,13];
        int j = 0;

        while(!endOfFile)
        {
            
            string data_String = strReader.ReadLine();
            if(data_String == null)
            {
                endOfFile = true;
                break;
            }
            var data_Values = data_String.Split(',');

            for (int i = 0; i < (data_Values.Length); i++)
            {
                //Debug.Log("Value:" + i.ToString() + " " + data_Values[i].ToString());
                array[j, i] = data_Values[i].ToString();
            }

            j++;

          
            //Debug.Log(data_Values[0].ToString() + " " + data_Values[1].ToString() + " " + data_Values[2].ToString()
            //+ " " + data_Values[3].ToString() + " " + data_Values[4].ToString() + " " + data_Values[5].ToString()
            //+ " " + data_Values[6].ToString() + " " + data_Values[7].ToString() + " " + data_Values[8].ToString()
            //+ " " + data_Values[9].ToString() + " " + data_Values[10].ToString() + " " + data_Values[11].ToString()
            //+ " " + data_Values[12].ToString());
        }
        //Debug.Log(array[10,2]);
        
    }

    void LoadQuestions()
    {
        question = new string[60];
        int i;
        int k;
        int j = 7;

        for(i = 0, k = 1; i < 10; i++ , k++)
        {
            
            question[i] = array[0, j] + " " + array[k, j];
            
        }

        j++;

        for (i = 10, k = 1; i < 20; i++, k++)
        {
            
            question[i] = array[0, j] + " " + array[k, j];
            
        }

        j++;

        for (i =20, k = 1; i < 30; i++, k++)
        {
            
            question[i] = array[0, j] + " " + array[k, j];
            
        }

        j++;

        for (i = 30, k = 1; i < 40; i++, k++)
        {
            
            question[i] = array[0, j] + " " + array[k, j];
            
        }

        j++;

        for (i = 40, k = 1; i < 50; i++, k++)
        {
            
            question[i] = array[0, j] + " " + array[k, j];
            
        }

        j++;

        for (i = 50, k = 1; i < 60; i++, k++)
        {
            
            question[i] = array[0, j] + " " + array[k, j];
            
        }

    }
    void LoadAnswers()
    {
        answer = new string[60];
        int i;
        int k;
        int j = 1;

        for (i = 0, k = 1; i < 10; i++, k++)
        {
            
            answer[i] = array[0, j] + " " + array[k, j];
            
        }

        j++;

        for (i = 10, k = 1; i < 20; i++, k++)
        {
            
            answer[i] = array[0, j] + " " + array[k, j];
            
        }

        j++;

        for (i = 20, k = 1; i < 30; i++, k++)
        {
            
            answer[i] = array[0, j] + " " + array[k, j];
            
        }

        j++;

        for (i = 30, k = 1; i < 40; i++, k++)
        {
            
            answer[i] = array[0, j] + " " + array[k, j];
            
        }

        j++;

        for (i = 40, k = 1; i < 50; i++, k++)
        {
            
            answer[i] = array[0, j] + " " + array[k, j];
            
        }

        j++;

        for (i = 50, k = 1; i < 60; i++, k++)
        {
            
            answer[i] = array[0, j] + " " + array[k, j];
            
        }
    }
}