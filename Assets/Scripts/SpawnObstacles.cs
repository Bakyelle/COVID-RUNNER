using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour

{
    public GameObject obstacle;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float timeBetweenSpwan;
    private float spawnTime;


    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpwan;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX,maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle,transform.position + new Vector3(randomY,randomX,0),transform.rotation);
    }
}
