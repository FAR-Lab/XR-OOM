using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using sl;
public class Calibrate : MonoBehaviour
{


    public float height = 0;
    private bool ZedToCarCalibrated = false; // This shold really be an enume with multiple calibration steps


    public bool UseXZYawParenting = false;
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
        if (Input.GetKeyDown(KeyCode.X) && 
            zedManager.ZEDTrackingState == sl.TRACKING_STATE.TRACKING_OK && 
            ZedToCarCalibrated==false)
        {
            ZedToCarCalibrated = true;
            if (!UseXZYawParenting)
            {
                transform.position += zedManager.transform.position - transform.position;
                transform.parent = zedManager.transform;
                Debug.Log(zedManager.ZEDTrackingState + 
                    "  " + zedManager.transform.position.y.ToString());
            }
            else
            {
                //ZedToCarOffset = zedManager.transform.position - ZedLocationCar.position;
                ZedToCarYaw = zedManager.transform.eulerAngles.y - transform.eulerAngles.y;
            }
        }
        else if (ZedToCarCalibrated)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                
                if (!UseXZYawParenting)
                {
                    VRWorldZero.parent = transform;
                    Quaternion tempRotation = Quaternion.FromToRotation(VRHeadset.forward, CallibrationPosition.forward);
                    Debug.Log(tempRotation.eulerAngles.magnitude.ToString() + "Adjusting orientation" + tempRotation.eulerAngles.ToString()); ;
                    VRWorldZero.rotation = tempRotation * VRWorldZero.rotation;

                    Vector3 temp = CallibrationPosition.position - VRHeadset.position;
                    Debug.Log(temp.magnitude.ToString() + "Adjusting position" + temp.ToString()); ;
                    VRWorldZero.position += temp;
                }
                else
                {

                     CarToXRYaw = Quaternion.FromToRotation(VRHeadset.forward, CallibrationPosition.forward).eulerAngles.y;
                    Debug.Log(" Yaw Offset" + CarToXRYaw.ToString());
                    CarToXROffset = CallibrationPosition.position - VRHeadset.position;
                }
            }
        }

    //    Debug.DrawRay(Vector3.zero, VRWorldZero.forward, Color.green);
      //  Debug.DrawRay(Vector3.zero, VRHeadset.forward, Color.red);
       // Debug.DrawRay(Vector3.zero, transform.forward, Color.blue);

//        Debug.DrawRay(VRWorldZero.position, VRWorldZero.forward, Color.green);
  //      Debug.DrawRay(VRHeadset.position, VRHeadset.forward, Color.red);
    //    Debug.DrawRay(transform.position, transform.forward, Color.blue);
    }
    private void LateUpdate()
    {
        
        if (UseXZYawParenting)
        {
            transform.position = new Vector3(zedManager.transform.position.x, height, zedManager.transform.position.z);
             Vector3 newRotation = new Vector3(
                 transform.eulerAngles.x,
                 zedManager.transform.eulerAngles.y+ ZedToCarYaw,
                 transform.eulerAngles.z);
            transform.eulerAngles = newRotation;


            VRWorldZero.position = CallibrationPosition.position + CarToXROffset;
            newRotation = new Vector3(
                VRWorldZero.eulerAngles.x,
                CallibrationPosition.eulerAngles.y+ ZedToCarYaw,
                VRWorldZero.eulerAngles.z);
            VRWorldZero.eulerAngles = newRotation;

        }
    }
}

