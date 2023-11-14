using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("PauseMenu.cs loaded!"); 
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
