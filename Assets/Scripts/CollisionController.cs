using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    //Alex Kent worked on this 
    //Collision control on objects 
   // public bool notsafe;

    void Start()
    {
       // notsafe = false;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Trigger was called");

        if (other.CompareTag("Goal"))
        {
           // Debug.Log("Goal was called");
            transform.position = new Vector2(4, -200);
            GameObject.Find("ScoreText").GetComponent<ScoreManager>().Score+=50;
            GameObject.Find("TimerText").GetComponent<Timer>().time = 60;
        }
        if (other.CompareTag("DeathTag"))
        {
            // Debug.Log("Death was called");
            //GetComponent<PlayerController>().frogDead = true;
            transform.position = new Vector2(4, -200);
            GameObject.Find("LivesScript").GetComponent<FroggerLives>().Lives--;
            GameObject.Find("TimerText").GetComponent<Timer>().time = 60;


            //transform.position = new Vector2(4, -200);
        }

        if (other.CompareTag("DestroyTag") && !this.CompareTag("ObjectLand"))
        {
          //  Debug.Log("Destory was called");
            Destroy(this.gameObject);
        }
        if(this.CompareTag("Player") && other.CompareTag("Water") )
        {
           transform.position = new Vector2(4, -200);
               GameObject.Find("LivesScript").GetComponent<FroggerLives>().Lives--;
               GameObject.Find("TimerText").GetComponent<Timer>().time = 60;
        }
        
    }
    void OnTriggerExit2D(Collider2D other)
    {
        
        if (other.CompareTag("DestroyTag") && this.CompareTag("ObjectLand"))
        {
            //  Debug.Log("Destory was called");
            Destroy(this.gameObject);
        }
        if (other.CompareTag("DestroyTag") && this.CompareTag("Water"))
        {
            //  Debug.Log("Destory was called");
            Destroy(this.gameObject);
        }
    }

    //void OnTriggerStay2D(Collider2D other)
    //{
      //  if (this.CompareTag("Player") && other.CompareTag("Water") && notsafe)
       // {
         //   transform.position = new Vector2(4, -200);
          //  notsafe = false;

        //}
    }


