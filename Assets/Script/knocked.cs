using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knocked : MonoBehaviour
{
    public GameObject ded; // Get the popup panel when knocked.
    public AudioSource aud;
    public AudioSource knockedAud;
    public GameObject breakRec;

    void Start()
    {
        Time.timeScale=1;
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D cls){
        knockedAud.Play();
        Time.timeScale=0;
        aud.Stop();

        if (FindObjectOfType<getBest>().getIsBest()){
            breakRec.SetActive(true);
        }
        else{
            ded.SetActive(true);
        }
    }

    public void bestDone(){
        breakRec.SetActive(false);
        ded.SetActive(true);
    }
}
