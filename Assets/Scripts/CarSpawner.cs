using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    //Kent worked on this
    //Spawns cars in
    public float Delay = 2f;
    public GameObject car;

   // public Transform[] spawnPoint;

    float TimetoSpawn = 0f;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(TimetoSpawn <= Time.time)
        {
            SpawnCar();
            TimetoSpawn = Time.time + Delay;
        }
    }

     void SpawnCar()
    {
        
        Instantiate(car);
    }
}
