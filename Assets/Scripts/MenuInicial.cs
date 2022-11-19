using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    
    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }

    public void Salir() 
    {
        Debug.Log("Saliendo...");
        Application.Quit();
    }

     public void volver()
    {
        SceneManager.LoadScene(0);
        
    }

    public void puntajes()
    {
        SceneManager.LoadScene(3);
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.V))
        {
            volver();
        }
       
    }


    

}
