using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ded : MonoBehaviour
{
    public Text txt;

    void Start(){
        txt.text = "Your score is "+FindObjectOfType<score>().getScore().ToString();
    }

    public void again(){
        SceneManager.LoadScene(1);
        Time.timeScale=1;
    }

    public void quit(){
        SceneManager.LoadScene(0);
    }
}
