using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour{

    public GameObject enemy;
    public Transform[] spawnSpots;
    private float TimeBtwSpawns;
    public float startTimeBtwSpawns;

    void Start(){
        float timeBtwSpawns = startTimeBtwSpawns;
    }

    void Update(){
        if (TimeBtwSpawns <= 0)
        {
            int randPos = Random.Range(0, spawnSpots.Length);
            Instantiate(enemy, spawnSpots[randPos].position, Quaternion.identity);
            TimeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            TimeBtwSpawns -= Time.deltaTime;
        }
    }
}
