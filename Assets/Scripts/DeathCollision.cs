using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollision : MonoBehaviour
{
    public GameObject WallPrefabRight;
    public GameObject WallPrefabLeft;
    public GameObject WallPrefabUp;
    public GameObject WallPrefabDown;
    public GameObject SpawnerUp;
    public GameObject SpawnerDown;
    public GameObject SpawnerLeft;
    public GameObject SpawnerRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Destroy(other.gameObject);
        
            WallPrefabDown.SetActive(false);
            WallPrefabLeft.SetActive(false);
            WallPrefabRight.SetActive(false);
            WallPrefabUp.SetActive(false);

        Debug.Log("Game Over!");

            Destroy(SpawnerDown);
            Destroy(SpawnerLeft);
            Destroy(SpawnerRight);
            Destroy(SpawnerUp);


    }
}
