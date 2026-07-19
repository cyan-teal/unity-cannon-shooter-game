using System;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class BallSpawner : MonoBehaviour
{
    public GameObject Ballprefab;
    public int number;
    public float spawnRadius;
    public bool spawnOnStart;
    public double secondsBetweenSpawns;
    private double i;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        i = 0;
        
        Debug.Log(spawnOnStart);
        if (spawnOnStart)
        {
            SpawnAll();
        }
        
    }
    void SpawnAll()
    {
        for (int i = 0; i < number; i++)
        {
            Vector3 randomPoint = this.transform.position + UnityEngine.Random.insideUnitSphere * spawnRadius;
            randomPoint.y = this.transform.position.y;
            //NavMeshHit hit;
            //if (NavMesh.SamplePosition(randoPoint, out hit, 10.0f, NavMesh.AllAreas))
            //{
            Instantiate(Ballprefab, randomPoint, Quaternion.identity);
            //}



        }
    }

    // Update is called once per frame
    void Update()
    {
        i += 1 * Time.deltaTime;
        if(i > secondsBetweenSpawns)
        {
            i = 0;
            SpawnAll();
        }
    }
}
