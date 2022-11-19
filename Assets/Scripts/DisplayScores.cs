using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScores : MonoBehaviour
{
    public HighScores scores;
    public TextMeshProUGUI texto;
    
    
    // Start is called before the first frame update
    void Start()
    {
        scores = HighScoresManager.Load();
            texto.SetText("High scores: \n\n" + scores.firstSavedScore + '\n' + scores.secondSavedScore + '\n' + scores.thirdSavedScore + '\n' + scores.fourthSavedScore + '\n' + scores.fifthSavedScore + '\n');
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
