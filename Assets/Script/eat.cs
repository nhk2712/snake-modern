using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eat : MonoBehaviour
{
    public AudioSource aud;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D cls){
        FindObjectOfType<body>().ate();
        FindObjectOfType<foodCreate>().ate();
        FindObjectOfType<score>().upScore();
        FindObjectOfType<movement>().incSpd();
        FindObjectOfType<movement>().unFreeze();
        aud.Play();
    }
}
