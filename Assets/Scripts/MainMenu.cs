using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("MainMenu.cs Loaded!");
    }

    public void QuitGame() {
        Debug.Log("Application Quit");
        Application.Quit();
    }

    public void PlayGame() {
        SceneManager.LoadScene("Level01");
    }
}
