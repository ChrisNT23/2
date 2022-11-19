using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Vida : MonoBehaviour
{
    public int health = 10;
    public TextMeshProUGUI texto2;
    public HighScores hs;
    public puntaje gm;
    
    void Update()
    {
        texto2.SetText("Vida: " + health);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
       

        if(health <= 0)
        {
                /*Guarda si el score es mayor */
               hs = HighScoresManager.Load();
                if (hs.fifthSavedScore <= gm.contador || hs.fifthSavedScore == 0)
                {
                    hs.fifthSavedScore = gm.contador;
                }
                HighScoresManager.Save(hs);
                SceneManager.LoadScene(2);
        }
    }

    public void TakeHealth(int damage)
    {
        health += damage;
    }

   
   
    
}
