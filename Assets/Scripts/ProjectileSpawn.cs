using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
    public GameObject projectilePrefabs;
 
    private float startDelayMin = 1;
    private float startDelayMax = 5;
    private float spawnIntervalMin = 2;
    private float spawnIntervalMax = 6;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnProjectile", Random.Range(startDelayMin, startDelayMax), Random.Range(spawnIntervalMin, spawnIntervalMax));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnProjectile()
    {
        Instantiate(projectilePrefabs, transform.position, gameObject.transform.rotation);
    }

}
