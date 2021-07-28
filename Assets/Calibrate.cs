﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using sl;
public class Calibrate : MonoBehaviour
{


   // public float height = 0;
    private bool ReadyForCalibration=false;
    private bool calibrationFinished = false;

    private Vector3 ZedToCarOffset;
    private float ZedToCarYaw;
    
    private float CarHeight = 0;

    private Vector3 CarToXROffset;
    private float CarToXRYaw;

    /// <summary>
    /// Relative to the world car<>world
    /// </summary>
    public Transform ZedCameraTracker;
 
    public Transform VRHeadset;
    public Transform VRWorldZero;
    public Transform CallibrationPosition; // SHould be on the center arm rest


    private ZEDManager zedManager;


    // Start is called before the first frame update
    void Start()
    {
        if (ZedCameraTracker != null)
        {
            zedManager = ZedCameraTracker.GetComponent<ZEDManager>();
            CarHeight = -(zedManager.transform.position.y - transform.position.y);
        }

    }

    public void MoveGameObject()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (!ReadyForCalibration)
        {
            if (zedManager.ZEDTrackingState == sl.TRACKING_STATE.TRACKING_OK)
            {
                ReadyForCalibration = true;
               // CarHeight = transform.position.y;
                transform.parent = zedManager.transform;
            }
            
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.X) && ! calibrationFinished)
            {
                CarToXROffset = CallibrationPosition.position - VRHeadset.position;
                calibrationFinished = true;
                VRWorldZero.transform.position += CarToXROffset;
                VRWorldZero.transform.parent = transform;

            }
            else if(Input.GetKey(KeyCode.Z) && calibrationFinished)
            {
                // CarToXRYaw = VRHeadset.rotation.eulerAngles.y - CallibrationPosition.rotation.eulerAngles.y;
                Vector3 HeadsetForward = new Vector3(VRHeadset.forward.x,0,VRHeadset.forward.z);
                Vector3 CallibForward = new Vector3(CallibrationPosition.forward.x, 0, CallibrationPosition.forward.z);


                CarToXRYaw = Vector3.Angle(HeadsetForward, CallibForward);
               
                if(Vector3.Cross(HeadsetForward, CallibForward).y<0)
                {
                   CarToXRYaw = -CarToXRYaw;
                }
                
                Debug.Log(CarToXRYaw);
                Debug.DrawRay(VRHeadset.position,VRHeadset.forward,Color.green,10f);
                Debug.DrawRay(CallibrationPosition.position, CallibrationPosition.forward, Color.red, 10f);
                VRWorldZero.RotateAround(VRWorldZero.position,Vector3.up,CarToXRYaw/10F);
            }
        }


    }
    private void LateUpdate()
    {

        if (calibrationFinished)
        {
         transform.position = new Vector3(transform.position.x, CarHeight, transform.position.z);
        }
    }
}

