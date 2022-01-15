using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Math;
using System.Globalization;
using System.IO;

public class soundHome : MonoBehaviour
{
    public Slider slider;

    string txt;
    double num;

    void Start()
    {
        if (File.Exists(Application.persistentDataPath+"\\sound.txt")==false){
            Debug.Log("no file");
            File.WriteAllText(Application.persistentDataPath+"\\sound.txt","0,5");
        }
        
        txt = File.ReadAllText(Application.persistentDataPath+"\\sound.txt");

        // Get the sound volume
        Debug.Log(txt);

        if (txt!="1"){
            num = double.Parse(txt,CultureInfo.InvariantCulture.NumberFormat);
            num/=Pow(10,txt.Length-2);
        }
        else{
            num=1;
        }
        
        // Set the sound volume
        Debug.Log(num);
        slider.value = (float)num;
    }

    public void change(){
        File.WriteAllText(Application.persistentDataPath+"\\sound.txt",slider.value.ToString());
    }
}
