using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI; 


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Pause();
            }
            else if(Input.GetKeyDown(KeyCode.R)) 
            {
                Resume();
            }
            else if(Input.GetKeyDown(KeyCode.M)) 
            {
                LoadMenu();
            } else if(Input.GetKeyDown(KeyCode.Q)) 
            {
                QuitGame();
            }
            
        }
    


    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale =1f;
        GameIsPaused = false;
         Cursor.visible = false;



    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu() 
    {
        Time.timeScale = 1f;
        Debug.Log("Loading Menu...");
        SceneManager.LoadScene(0);
    }

    public void QuitGame() 
    {
         Debug.Log("Quiting game...");
         Application.Quit();
         SceneManager.LoadScene(2);
    }

    

}
