using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            click();
        }
    }

    public void click(){
        Time.timeScale=0;
        panel.SetActive(true);
    }

    public void play(){
        Time.timeScale=1;
        panel.SetActive(false);
        FindObjectOfType<countdown>().init();
    }

    public void again(){
        SceneManager.LoadScene(1);
        Time.timeScale=1;
    }

    public void quit(){
        SceneManager.LoadScene(0);
        Time.timeScale=1;
    }
}
