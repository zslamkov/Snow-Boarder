using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
[SerializeField] private float delay = 2f;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground"){
            Invoke("ReloadScene", delay);
            }
    }

    void ReloadScene(){
        SceneManager.LoadScene(0);
    }  
}

