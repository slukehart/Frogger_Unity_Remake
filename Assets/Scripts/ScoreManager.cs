using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //Olivia Ashley worked on this
    //Debugged by Alex Kent
    public int Score;
    public Text ScoreText;

    void Start()
    {
        Score = 0;
    }

    public void Update()
    {
        if (Score < 0)
            Score = 0;
        ScoreText.text = "Score: " + Score;
        AddPoints();
    }

    public void AddPoints()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            Score += 10;
      
        if (Input.GetKeyDown(KeyCode.DownArrow))
            Score -= 10;
        if(GameObject.Find("GoalManager").GetComponent<GoalManager>().counter == 0)
        {
            Score += 100;
        }
    }
}