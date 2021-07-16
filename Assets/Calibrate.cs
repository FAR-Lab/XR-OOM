using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using sl;
public class Calibrate : MonoBehaviour
{


    public float height = 0;
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
                CarHeight = transform.position.y;
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
            else if(Input.GetKeyDown(KeyCode.Z) && calibrationFinished)
            {
                CarToXRYaw = VRHeadset.rotation.eulerAngles.y - CallibrationPosition.rotation.eulerAngles.y;

                VRWorldZero.RotateAround(VRWorldZero.transform.position,Vector3.up,CarToXRYaw);
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

