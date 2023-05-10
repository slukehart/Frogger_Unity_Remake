using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Alex Kent worked on Movement and animations of Player
    public float speed; //Incase needed to change this for now haven't
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Player_Movement();
        PlayerReset();
    }

    public void Player_Movement()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < 180)
        {
            transform.position += speed * new Vector3(0, 30);
            animator.SetBool("Up", true);
            animator.SetBool("LastKeyDown", false);
            animator.SetBool("LastKeyRight", false);
            animator.SetBool("LastKeyLeft", false);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            animator.SetBool("Up", false);

        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > -200)
        {
            transform.position += speed * new Vector3(0, -30);
            animator.SetBool("Down", true);
            animator.SetBool("LastKeyDown", true);
            animator.SetBool("LastKeyRight", false);
            animator.SetBool("LastKeyLeft", false);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            animator.SetBool("Down", false);

        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 200)
        {
            transform.position += speed * new Vector3(20, 0);
            animator.SetBool("Right", true);
            animator.SetBool("LastKeyRight", true);
            animator.SetBool("LastKeyDown", false);
            animator.SetBool("LastKeyLeft", false);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetBool("Right", false);

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -200)
        {
            transform.position += speed * new Vector3(-20, 0);
            animator.SetBool("Left", true);
            animator.SetBool("LastKeyLeft", true);
            animator.SetBool("LastKeyDown", false);
            animator.SetBool("LastKeyRight", false);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("Left", false);

        }
        
    }
    public void PlayerReset()
    {
        if(transform.position.x > 255) 
        {
            transform.position = new Vector2(4, -200);
        }
        if (transform.position.x < -255)
        {
            transform.position = new Vector2(4, -200);
        }
       
    }


}



