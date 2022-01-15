using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class getBest : MonoBehaviour
{
    string txt;
    int num;
    public Text view;
    bool isBest;

    void Start()
    {
        isBest = false;
        if (File.Exists(Application.persistentDataPath+"\\best.txt")==false){
            Debug.Log("no file");
            File.WriteAllText(Application.persistentDataPath+"\\best.txt","0");
        }
        
        txt = File.ReadAllText(Application.persistentDataPath+"\\best.txt");

        num=int.Parse(txt);
        show();
    }

    void show(){
        view.text="Best: "+num.ToString();
    }

    public void write(){
        if (FindObjectOfType<score>().getScore()>num){
            num=FindObjectOfType<score>().getScore();
            File.WriteAllText(Application.persistentDataPath+"\\best.txt",num.ToString());
            view.text="Best: "+num.ToString();
            isBest=true;
        }
    }

    public bool getIsBest(){
        return isBest;
    }
}
