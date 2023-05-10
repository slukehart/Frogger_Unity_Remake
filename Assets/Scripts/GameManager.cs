using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Alex Kent worked on this
    //public GameObject buttonGameObject;
    // Start is called before the first frame update
    private void Start()
    {
       // Button buttonComponent = buttonGameObject.GetComponent<Button>();
    }

    // Update is called once per frame
    public void OnStartPressed()
    { 
        SceneManager.LoadScene("Title");
    }

    public void OnQuitPressed()
    {
        Application.Quit();
    }
}
