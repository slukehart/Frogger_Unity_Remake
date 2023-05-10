using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    //Olivia Ashley worked on countdown timer
    //Debugged by Alex did edits to reset time on death and if timer runs out.
    public Text TimerText;
    public float time = 60;

    void Update()
    {
        time -= Time.deltaTime;
        var seconds = time%60;
        TimerText.GetComponent<Text>().text = (seconds.ToString());
        if(time == 0 || time < 0)
        {
            TimeUp();
        }
        
    }

    void TimeUp()
    {
            GameObject.Find("LivesScript").GetComponent<FroggerLives>().Lives--;
            time = 60;
            
    }

}
