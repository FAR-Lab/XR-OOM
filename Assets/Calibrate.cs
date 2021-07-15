using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using sl;
public class Calibrate : MonoBehaviour
{


    public float height = 0;
    private bool ZedToCarCalibrated = false; // This shold really be an enume with multiple calibration steps


    private Vector3 ZedToCarOffset;
    private float ZedToCarYaw;

    private Vector3 CarToXROffset;
    private float CarToXRYaw;

    /// <summary>
    /// Relative to the world car<>world
    /// </summary>
    public Transform ZedCameraTracker;
    //public Transform ZedLocationCar;



    /// <summary>
    /// Relative between headset and car
    /// </summary>
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
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ZedToCarCalibrated = false;
        }

        if (Input.GetKeyDown(KeyCode.X) &&
        zedManager.ZEDTrackingState == sl.TRACKING_STATE.TRACKING_OK &&
        ZedToCarCalibrated == false)
        {
           // ZedToCarCalibrated = true;
           // ZedToCarYaw = zedManager.transform.eulerAngles.y - transform.eulerAngles.y;
       
           // CarToXRYaw = Quaternion.FromToRotation(VRHeadset.forward, CallibrationPosition.forward).eulerAngles.y;
            CarToXRYaw = VRHeadset.rotation.eulerAngles.y- CallibrationPosition.rotation.eulerAngles.y;

            if (CarToXRYaw > 180f)
            {
                CarToXRYaw = -360 + CarToXRYaw;
            }
            else if (CarToXRYaw < -180f)
            {
                CarToXRYaw = 360 + CarToXRYaw;
            }


            Debug.Log(" Yaw Offset" + CarToXRYaw.ToString());
            CarToXROffset = CallibrationPosition.position - VRHeadset.position;
            

        }


    }
    private void LateUpdate()
    {

        if (true)//(ZedToCarCalibrated)
        {
          //  transform.position = new Vector3(zedManager.transform.position.x, height, zedManager.transform.position.z);
          //  Vector3 newRotation = new Vector3(
          //      transform.eulerAngles.x,
            //    zedManager.transform.eulerAngles.y + ZedToCarYaw,
              //  transform.eulerAngles.z);
         //   transform.eulerAngles = newRotation;


            Vector3 temp = (CallibrationPosition.position + CarToXROffset);
            temp.y = 0;
            VRWorldZero.position = temp;
            Vector3  newRotation = new Vector3(
                VRWorldZero.eulerAngles.x,
                CallibrationPosition.eulerAngles.y - CarToXRYaw,
                VRWorldZero.eulerAngles.z);
            VRWorldZero.eulerAngles = newRotation;

        }
    }
}

