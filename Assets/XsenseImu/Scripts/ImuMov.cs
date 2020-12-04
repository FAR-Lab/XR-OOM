using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImuMov : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 PlanarVelocity;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(XsenseImuMonoBehaviorWrapper.Instance != null){
            transform.rotation = XsenseImuMonoBehaviorWrapper.Instance.Orientation;
            PlanarVelocity.x += XsenseImuMonoBehaviorWrapper.Instance.Acceleration.x;
            PlanarVelocity.z += XsenseImuMonoBehaviorWrapper.Instance.Acceleration.z;
            PlanarVelocity.y = 0;
            transform.position += (PlanarVelocity*Time.deltaTime*0.01f);
        }   

    }
}
