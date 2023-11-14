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

    void OnCollisionEnter (Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Player") {
            Debug.Log("Loading Level02");
            SceneManager.LoadScene("Level02");
        }
    }
}
