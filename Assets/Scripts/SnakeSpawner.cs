using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeSpawner : MonoBehaviour
{

    //Alex Kent worked on this and animations for the snake.
    public float Delay = 2f;
    public GameObject snake;

    // public Transform[] spawnPoint;

    float TimetoSpawn = 0f;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (TimetoSpawn <= Time.time && GameObject.Find("GoalManager").GetComponent<GoalManager>().counter <= 2)
        {
            SpawnSnake();
            TimetoSpawn = Time.time + Delay;
        }
    }

    void SpawnSnake()
    {

        Instantiate(snake);
    }
}
