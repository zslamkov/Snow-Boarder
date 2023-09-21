using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
[SerializeField] private float delay = 2f;
[SerializeField] private ParticleSystem crashEffect;
[SerializeField] AudioClip crashSound;

public bool hasCrashed = false;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Ground" && !hasCrashed){
            hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableContols();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSound);
            Invoke("ReloadScene", delay);
            }
    }

    void ReloadScene(){
        hasCrashed = false;
        SceneManager.LoadScene(0);
    }  
}

