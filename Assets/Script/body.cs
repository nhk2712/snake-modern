using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class body : MonoBehaviour
{
    public GameObject init; // Get the inital snake's body
    public GameObject snake; // Get the current snake.
    public int maxTime; // The time that the body is duplicated.
    int time=0; // Time counter
    public float delete;

    void Start()
    {
        
    }

    void Update()
    {
        time++;
        if (time>maxTime){
            time=0;
            
        }
        GameObject tmp = Instantiate(init, snake.transform.position, Quaternion.identity);
        Destroy(tmp,delete);
    }

    public void ate(){
        delete+=0.1f;
    }
}
