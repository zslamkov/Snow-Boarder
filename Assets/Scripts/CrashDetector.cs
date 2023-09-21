using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
[SerializeField] private float delay = 2f;
[SerializeField] private ParticleSystem crashEffect;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground"){
            
            crashEffect.Play();
            Invoke("ReloadScene", delay);
            }
    }

    void ReloadScene(){
        SceneManager.LoadScene(0);
    }  
}

