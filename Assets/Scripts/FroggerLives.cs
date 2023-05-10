using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FroggerLives : MonoBehaviour
{
    //Olivia Ashley worked on this
    //Debugged by Alex Kent
    public int Lives;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;

    void Start()
    {
        Lives =3;
    }

    public void Update()
    {
        LivesCount();
    }

    public void LivesCount()
    {
        if (Lives == 2)
        {
            life1.SetActive(false);
        }
        if (Lives == 1)
        {
            life1.SetActive(false);
            life2.SetActive(false);
        }
        if (Lives == 0)
        {
            life1.SetActive(false);
            life2.SetActive(false);
            life3.SetActive(false);
            SceneManager.LoadScene("EndScreen");
        }
    
    }
}