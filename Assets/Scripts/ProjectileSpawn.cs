using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
    public GameObject[] projectilePrefabs;
    private float spawnPosX = 10;
    private float spawnRangeZ = 5;
    private float otherspawnPosX = -10;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnProjectileRight", startDelay, spawnInterval);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnProjectileRight()
    {
        //randomly spawn balls on the right

        Vector3 spawnPos = new Vector3((spawnPosX),0, Random.Range(-spawnRangeZ, spawnRangeZ));

        int ballIndex = Random.Range(0, projectilePrefabs.Length);

        Instantiate(projectilePrefabs[ballIndex], spawnPos,
        projectilePrefabs[ballIndex].transform.rotation);
    }

    void SpawnProjectileLeft()
    {
        //randomly spawn balls on the right

        Vector3 spawnPos = new Vector3((otherspawnPosX), 0, Random.Range(-spawnRangeZ, spawnRangeZ));

        int ballIndex = Random.Range(0, projectilePrefabs.Length);

        Instantiate(projectilePrefabs[ballIndex], spawnPos,
        projectilePrefabs[ballIndex].transform.rotation);
    }
}
