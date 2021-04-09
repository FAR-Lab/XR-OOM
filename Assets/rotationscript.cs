using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

// var rotationsPerMinute : float = 10.0;
    void Update()
    {
        transform.Rotate(0,0, 6 * 10 * Time.deltaTime);
    }
}


