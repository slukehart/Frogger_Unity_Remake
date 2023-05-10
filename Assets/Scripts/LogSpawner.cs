using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawner : MonoBehaviour

{
    //Spencer worked on this

    public float Delay = 2f;
    public GameObject log;
    //private Vector2 screenBounds;


    // public Transform[] spawnPoint;

    float TimetoSpawn = .25f;

    // Start is called before the first frame update


    // Update is called once per frame

    // void Start()
    //{
    //    screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    //}
    void Update()
    {
        if (TimetoSpawn <= Time.time)
        {
            SpawnLog();
            TimetoSpawn = Time.time + Delay;
        }

        //if (transform.position.x < screenBounds.x *2)
        //{
        //    Destroy(this.gameObject);
        //}
    }

    void SpawnLog()
    {

        Instantiate(log);
    }
}

