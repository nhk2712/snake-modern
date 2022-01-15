using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text txt;
    int scr = 0;

    void Start()
    {
        txt.text="Score: "+scr.ToString();
    }

    public void upScore(){
        scr+=10;
        txt.text="Score: "+scr.ToString();
        FindObjectOfType<getBest>().write();
    }

    public int getScore(){
        return scr;
    }
}
