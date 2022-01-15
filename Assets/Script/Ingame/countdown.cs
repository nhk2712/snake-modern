using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countdown : MonoBehaviour
{
    public GameObject three;
    public GameObject two;
    public GameObject one;
    float timer;
    public AudioSource aud;

    void Start()
    {
        init();
    }

    void Update()
    {
        if (timer<550) timer++;

        if (timer==180){
            three.SetActive(false);
            two.SetActive(true);
            aud.Play();
        }
        else if (timer==360){
            two.SetActive(false);
            one.SetActive(true);
            aud.Play();
        }
        else if (timer==540){
            one.SetActive(false);
            FindObjectOfType<movement>().unFreeze();
        }
    }

    public void init(){
        three.SetActive(true);
        aud.Play();
        FindObjectOfType<movement>().freeze();
        timer=0;
    }
}
