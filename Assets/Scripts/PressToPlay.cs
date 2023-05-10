using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressToPlay : MonoBehaviour
{
    // Detects if any key has been pressed.
    //Olivia worked on this
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
            SceneManager.LoadScene("MainGameScreen");
        {
            Debug.Log("A key or mouse click has been detected");
        }
    }
}