using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homePanel : MonoBehaviour
{
    public GameObject panel;
    public GameObject toQuit;
    public AudioSource aud;

    public void play(){
        SceneManager.LoadScene(1);
    }

    public void menu(){
        panel.SetActive(true);
    }

    public void closeMenu(){
        panel.SetActive(false);
    }

    public void quit(){
        toQuit.SetActive(true);
        aud.Pause();
        Time.timeScale=0;
    }

    public void yes(){
        Application.Quit();
    }

    public void no(){
        toQuit.SetActive(false);
        aud.UnPause();
        Time.timeScale=1;
    }
}
