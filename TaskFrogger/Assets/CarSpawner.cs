using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public float spawnDely = .3f;
    public float nextTimeToSpawn = 0f;
    public GameObject car;
    public Transform[] spawnPoints;


    private void Update()
    {

       if(nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + spawnDely;
        }    
    }


    void SpawnCar()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(car,spawnPoint.position,spawnPoint.rotation);       
    }
}
