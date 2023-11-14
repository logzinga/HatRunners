using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    public static bool gameIsPaused = false;


    public GameObject pauseMenu;

    void Start()
    {
       Debug.Log("PauseMenu.cs loaded!"); 

       
    }

    void Update () {
            if (Input.GetKeyDown(KeyCode.Escape)) {
                if (gameIsPaused) {
                    Resume();
                } else {
                    Pause();
                }
       }
    }

    public void Resume() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void Pause() {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void QuitGame() {
        Debug.Log("Application Quit");
        Application.Quit();
    }

    public void ReturnMain() {
        Debug.Log("Loading MainMenu");
        SceneManager.LoadScene("MainMenu");
    }

}
