using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntaje : MonoBehaviour
{
    public int contador = 0;
    public TextMeshProUGUI texto;

    // Start is called before the first frame update
    void Start()
    {
         Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        texto.SetText("Score: " +contador);
    }
}
