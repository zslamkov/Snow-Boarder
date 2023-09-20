using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float delay = 2f;
         void OnTriggerEnter2D(Collider2D other) {
            if(other.tag == "Player"){
            Invoke("ReloadScene", delay);
            }
    }

    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
