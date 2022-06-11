using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player") {
            Invoke("ReloadScene", 1f);
            Debug.Log("Restart Game in 1second.");
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene(0);
    }
}
