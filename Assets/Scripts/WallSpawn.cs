using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawn : MonoBehaviour
{
    public GameObject WallPrefabRight;
    public GameObject WallPrefabLeft;
    public GameObject WallPrefabUp;
    public GameObject WallPrefabDown;


    // Start is called before the first frame update
    void Start()
    {
        WallPrefabDown.SetActive(false);
        WallPrefabLeft.SetActive(false);
        WallPrefabRight.SetActive(false);
        WallPrefabUp.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
        WallPrefabDown.SetActive(true);
        WallPrefabLeft.SetActive(false);
        WallPrefabRight.SetActive(false);
        WallPrefabUp.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            WallPrefabDown.SetActive(false);
            WallPrefabLeft.SetActive(false);
            WallPrefabRight.SetActive(false);
            WallPrefabUp.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            WallPrefabDown.SetActive(false);
            WallPrefabLeft.SetActive(true);
            WallPrefabRight.SetActive(false);
            WallPrefabUp.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            WallPrefabDown.SetActive(false);
            WallPrefabLeft.SetActive(false);
            WallPrefabRight.SetActive(true);
            WallPrefabUp.SetActive(false);
        }
    }
}
