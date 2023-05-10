using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLandingCollision : MonoBehaviour
{
    //Spencer worked on this 
    //Alex Kent helped debug and work on turtles Spencer did most of the setup for this script though.
    private Rigidbody2D Player;
    private bool onLand = false;
    private bool onTurtle = false;
    private float speed = .5f;
   // private bool notsafe = false;
   // private float waiting;
    void Update()
    {
        if (onLand)
        {

            //Debug.Log("If statement reached");
            //Vector2 forward = new Vector2(transform.right.x, transform.right.y);

            transform.position = transform.position + Vector3.right * Time.deltaTime * speed;
           

            //Vector2 forward = new Vector2(transform.right.x, transform.right.y);
            //Player.transform.position = Vector2.right * Time.fixedDeltaTime * speed;


        }
        if (onTurtle)
        {
            transform.position = transform.position + Vector3.left * Time.deltaTime * speed;
            
        }

        
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger was called");



        if (other.CompareTag("ObjectLand"))
        {

            // Debug.Log("Landed on Log/Turtle");
            onLand = true; 
            //Debug.Log("On Land" + onLand);
            //aSprite = GameObject.FindWithTag("ObjectLand");
            speed = other.GetComponent<RightMovement>().speed;
            

        }
      //  else if (this.CompareTag("Player") && other.CompareTag("Water") && !onLand && !onTurtle)
      //  {
      //      transform.position = new Vector2(4, -200);
       // }
        if (other.CompareTag("TurtleLand"))
        {
            //Akent added this used to change for turtles
            // Debug.Log("Landed on Log/Turtle");
            onTurtle = true;
            //Debug.Log("On Land" + onLand);
            //aSprite = GameObject.FindWithTag("ObjectLand");
            speed = other.GetComponent<LeftMController>().speed;
            
        }
       // else if (this.CompareTag("Player") && other.CompareTag("Water") && !onTurtle && !onLand)
     //   {
       //     transform.position = new Vector2(4, -200);
       // }



    }
    //Akent added this unity doc Stay helps make the movement from onland to another work
        private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Trigger was called");



        if (other.CompareTag("ObjectLand"))
        {

           // Debug.Log("Landed on Log/Turtle");
            onLand = true;
            //Debug.Log("On Land" + onLand);
            //aSprite = GameObject.FindWithTag("ObjectLand");
            speed = other.GetComponent<RightMovement>().speed;
        }
        //else if (this.CompareTag("Player") && other.CompareTag("Water") && !onLand && !onTurtle)
       // {
       //     transform.position = new Vector2(4, -200);
       // }
        if (other.CompareTag("TurtleLand"))
        {
            //Akent added this used to change for turtles
            // Debug.Log("Landed on Log/Turtle");
            onTurtle = true;
            //Debug.Log("On Land" + onLand);
            //aSprite = GameObject.FindWithTag("ObjectLand");
            speed = other.GetComponent<LeftMController>().speed;
           
        }
       // else if (this.CompareTag("Player") && other.CompareTag("Water") && !onLand && !onTurtle)
       // {
        //    transform.position = new Vector2(4, -200);
       // }




    }


    private void OnTriggerExit2D(Collider2D other)
    {
        onTurtle = false;
        onLand = false;
    }

    void DetectCollisions()
    {
        //ObjectLandingCollision[] aSprite;
        //aSprite = GameObject.FindWithTag("ObjectLand");


    }

}
