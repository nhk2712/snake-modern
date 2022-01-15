using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class music : MonoBehaviour
{
    public Slider slider;
    public AudioSource aud;

    void Start()
    {
        FindObjectOfType<getMusic>().setMusic();
    }

    void Update()
    {

    }

    public void change(){
        aud.volume = slider.value;
        write();
    }

    void write(){
        System.IO.File.WriteAllText(Application.persistentDataPath+"\\music.txt",slider.value.ToString());
    }
}
