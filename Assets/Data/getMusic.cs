using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Math;
using System.Globalization;
using UnityEngine.UI;
using System.IO;

public class getMusic : MonoBehaviour
{
    string txt;
    double num;
    public AudioSource music;
    public Slider slider;

    void Start()
    {
        if (File.Exists(Application.persistentDataPath+"\\music.txt")==false){
            Debug.Log("no file");
            File.WriteAllText(Application.persistentDataPath+"\\music.txt","0,5");
        }
        
        txt = File.ReadAllText(Application.persistentDataPath+"\\music.txt");
        setMusic();
    }

    public void setMusic(){
        // Get the music volume
        Debug.Log(txt);

        if (txt!="1"){
            num = double.Parse(txt,CultureInfo.InvariantCulture.NumberFormat);
            num/=Pow(10,txt.Length-2);
        }
        else{
            num=1;
        }
        
        // Set the music volume
        Debug.Log(num);
        music.volume = (float)num;
        slider.value = (float)num;
    }
}
