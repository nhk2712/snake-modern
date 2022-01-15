using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homeEffect : MonoBehaviour
{
    public SpriteRenderer obj;
    public int maxTime;
    int time=0;

    void Start()
    {
        
    }

    void Update()
    {
        time++;
        if (time>maxTime){
            time=0;
            if (obj.flipY==false){
                obj.flipY=true;
            }
            else{
                obj.flipY=false;
            }
        }
    }
}
