using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{
    //Alex Kent worked on this
   
    // Start is called before the first frame update
    public GameObject GoalFrog;
   public bool GoalFrogActive = false;

    public void ShowFrog(bool showFrog)
    {
        GoalFrog.SetActive(showFrog);
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ShowFrog(true);
            Counter();
        }
    }

    public void Counter()
    {
        
        if (GoalFrogActive == false)
        {
            GameObject.Find("GoalManager").GetComponent<GoalManager>().counter--;
            GoalFrogActive = true; 
        }
        
        //GameObject.Find("GoalManager").GetComponent<GoalManager>().counter--;

    }


    
}
