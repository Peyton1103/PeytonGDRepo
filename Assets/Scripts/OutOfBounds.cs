using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    private float topBound = 13;
    private float lowerBound = -13;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > topBound)
        {
            
            Destroy(gameObject);
        }
        else if (transform.position.x < lowerBound)
        {
            
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
           
            Destroy(gameObject);
        }
        else if (transform.position.z > topBound)
        {
            
            Destroy(gameObject);
        }
    }
}
