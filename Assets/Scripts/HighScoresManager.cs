using UnityEngine;
using System.IO;
using System;


public class HighScoresManager : MonoBehaviour
{
    /*Se asigna el nombre y el directorio del archivo*/
    public static string directory = "/SaveData/";
    public static string fileName = "scoreData.txt";

    public static void Save(HighScores score)
    {
        /*se hacen variables temporales para ordenar el score*/
        int first = score.firstSavedScore;
        int second = score.secondSavedScore;
        int third = score.thirdSavedScore;
        int fourth = score.fourthSavedScore;
        int fifth = score.fifthSavedScore;

        int[] highScores = new int[] {first, second, third, fourth, fifth};

        Array.Sort(highScores);

            /*Se ordena el arreglo de los puntajes */
        score.fifthSavedScore = highScores[0];
        score.fourthSavedScore = highScores[1];
        score.thirdSavedScore = highScores[2];
        score.secondSavedScore = highScores[3];
        score.firstSavedScore = highScores[4];
       
        
        
        
         
           

        string dir = Application.persistentDataPath + directory;
        Debug.Log(dir);

        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        string json = JsonUtility.ToJson(score);
        File.WriteAllText(dir + fileName, json);
    }

    public static HighScores Load()
    {
        string fullPath = Application.persistentDataPath + directory + fileName;
        HighScores score = new HighScores();

        if (File.Exists(fullPath))
        {
            string json = File.ReadAllText(fullPath);
            score = JsonUtility.FromJson<HighScores>(json);
        }
        else
        {
            Debug.Log("No existe el archivo");
        }
        return score;
    }
}
