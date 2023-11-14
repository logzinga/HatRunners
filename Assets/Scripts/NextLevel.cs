using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("NextLevel.cs loaded!");
    }

    public string nextStage;

    void OnCollisionEnter (Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Player 2") {
            Debug.Log("Loading " + nextStage);
            SceneManager.LoadScene(nextStage);
        }
    }
}
