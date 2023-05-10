using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    //Alex kent worked on this
    public int counter = 5;
    public GameObject GoalFrog1;
    public GameObject GoalFrog2;
    public GameObject GoalFrog3;
    public GameObject GoalFrog4;
    public GameObject GoalFrog5;
    void Update()
    {
        if(counter == 0)
        {
            GoalFrog1.SetActive(false);
            GoalFrog2.SetActive(false);
            GoalFrog3.SetActive(false);
            GoalFrog4.SetActive(false);
            GoalFrog5.SetActive(false);
            counter = 5;
            GameObject.Find("Goal1").GetComponent<GoalController>().GoalFrogActive = false;
            GameObject.Find("Goal2").GetComponent<GoalController>().GoalFrogActive = false;
            GameObject.Find("Goal3").GetComponent<GoalController>().GoalFrogActive = false;
            GameObject.Find("Goal4").GetComponent<GoalController>().GoalFrogActive = false;
            GameObject.Find("Goal5").GetComponent<GoalController>().GoalFrogActive = false;
            GameObject.Find("ScoreText").GetComponent<ScoreManager>().Score+=500;


        }
    }
}
