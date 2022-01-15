using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public GameObject snake;
    public float speed;
    float tmpSpeed;

    const int UP = 1;
    const int DOWN = 2;
    const int LEFT = 3;
    const int RIGHT = 4;
    int state = RIGHT; // State of the snake's movement. Set the initial orientation to right.

    void Start()
    {
        tmpSpeed=0f;
    }

    void Update()
    {
        // This can change the snake's orientation when keys are held.
        if ( (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
         && state!=UP){
            state=DOWN;
        }
        else if ( (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
         && state!=DOWN){
            state=UP;
        }
        else if ( (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
         && state!=RIGHT){
            state=LEFT;
        }
        else if ( (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
         && state!=LEFT){
            state=RIGHT;
        }

        // By doing this, make the snake move continuously.
        if (state==RIGHT/* && snake.transform.position.x<=8.15*/){
            snake.transform.position += Vector3.right * tmpSpeed * Time.deltaTime;
        }
        else if (state==LEFT/* && snake.transform.position.x>=-8.15*/){
            snake.transform.position += Vector3.left * tmpSpeed * Time.deltaTime;
        }
        else if (state==UP/* && snake.transform.position.y<=4.3*/){
            snake.transform.position += Vector3.up * tmpSpeed * Time.deltaTime;
        }
        else if (state==DOWN/* && snake.transform.position.y>=-4.3*/){
            snake.transform.position += Vector3.down * tmpSpeed * Time.deltaTime;
        }

    }

    public void moveDown(){
        if (state!=UP) state=DOWN;
    }

    public void moveUp(){
        if (state!=DOWN)state=UP;
    }

    public void moveLeft(){
        if (state!=RIGHT) state=LEFT;
    }

    public void moveRight(){
        if (state!=LEFT) state=RIGHT;
    }

    public void freeze(){
        tmpSpeed=0f;
    }

    public void unFreeze(){
        tmpSpeed=speed;
    }

    public void incSpd(){
        speed+=0.01f;
    }
}
