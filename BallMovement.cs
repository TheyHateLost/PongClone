using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    //variable for speed 
    public float xSpeed = 0; //variable for x speed 
    private float xBorder = 0; //variable for y speed 

    //variable borders 
    private float xBorder = 7.5f; //variable for horizonal border 
    private float yborder = 4.5f; //variable for vertical border 



    // Start is called before the first frame update
    void Start()
    { 
    xSpeed = 0.0125f; //declare value for horizonal speed 
    yspeed = 0.0125f; // declare value for vertical speed 
    }



    // Update is called once per frame
    void Update()
    {
        //horizonal movement
        transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y); //move right 
        if (transform.position.x >= xBorder)

        {
            xSpeed = -xSpeed; //make it go left 
        }
    }
}
