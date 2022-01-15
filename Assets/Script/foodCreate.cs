using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodCreate : MonoBehaviour
{
    GameObject tmp;
    public GameObject food;

    void Start()
    {
        init();
    }

    public void init(){
        tmp=Instantiate(
            food,
            new Vector3(
                Random.Range(-2.74f,2.75f),
                Random.Range(-2.45f,2.48f),
                0
            ),
            Quaternion.identity
        );
    }

    public void ate(){
        Destroy(tmp,0.1f);

        tmp=Instantiate(
            food,
            new Vector3(
                Random.Range(-2.74f,2.75f),
                Random.Range(-2.45f,2.48f),
                0
            ),
            Quaternion.identity
        );
    }
}
