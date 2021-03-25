﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calibrate : MonoBehaviour
{
    public GameObject OffsetObject;
    public GameObject TrackedVirtualMarkPosition;
    public GameObject TargetFixedPositionMarker;
  
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MoveGameObject()
    {
        Debug.Log(Quaternion.FromToRotation(TrackedVirtualMarkPosition.transform.forward, TargetFixedPositionMarker.transform.forward).eulerAngles.magnitude);

        OffsetObject.transform.rotation *=  Quaternion.FromToRotation(TrackedVirtualMarkPosition.transform.forward, TargetFixedPositionMarker.transform.forward);
        Debug.Log(Quaternion.FromToRotation(TrackedVirtualMarkPosition.transform.forward, TargetFixedPositionMarker.transform.forward).eulerAngles.magnitude);
        Vector3 positionadjust = TargetFixedPositionMarker.transform.position - TrackedVirtualMarkPosition.transform.position;
        OffsetObject.transform.position += positionadjust;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyUp(KeyCode.X))
        {
            MoveGameObject();
        }*/
    }
}

