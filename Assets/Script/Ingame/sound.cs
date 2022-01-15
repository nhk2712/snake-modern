using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sound : MonoBehaviour
{
    public Slider slider;
    public AudioSource knocked;
    public AudioSource eat;
    public AudioSource count;

    void Start()
    {
        FindObjectOfType<getSound>().setSound();
    }

    void Update()
    {
        
    }

    public void change(){
        knocked.volume=slider.value;
        eat.volume=slider.value;
        count.volume=slider.value;

        write();
    }

    void write(){
        System.IO.File.WriteAllText(Application.persistentDataPath+"\\sound.txt",slider.value.ToString());
    }
}
