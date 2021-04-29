using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using sl;
public class Calibrate : MonoBehaviour
{

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
    public Transform ZedLocationCar;



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
                transform.position += zedManager.transform.position - ZedLocationCar.position;
                transform.parent = zedManager.transform;
                Debug.Log(zedManager.ZEDTrackingState + 
                    "  " + zedManager.transform.position.y.ToString());
            }
            else
            {
                ZedToCarOffset = zedManager.transform.position - ZedLocationCar.position;
                ZedToCarYaw = zedManager.transform.eulerAngles.y - ZedLocationCar.eulerAngles.y;
            }
        }
        else if (ZedToCarCalibrated)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                if (!UseXZYawParenting)
                {
                    Quaternion tempRotation = Quaternion.FromToRotation(VRHeadset.forward, CallibrationPosition.forward);
                    Debug.Log(tempRotation.eulerAngles.magnitude.ToString() + "Adjusting orientation" + tempRotation.eulerAngles.ToString()); ;
                    VRWorldZero.rotation = tempRotation * VRWorldZero.rotation;

                    Vector3 temp = CallibrationPosition.position - VRHeadset.position;
                    Debug.Log(temp.magnitude.ToString() + "Adjusting position" + temp.ToString()); ;
                    VRWorldZero.position += temp;
                }
                else
                {

                    float tempRotation = Quaternion.FromToRotation(VRHeadset.forward, CallibrationPosition.forward).eulerAngles.y;
                    Debug.Log(tempRotation.ToString() + "Adjusting orientation" ); ;
                    VRWorldZero.Rotate(Vector3.up, tempRotation);


                    Vector3 temp = CallibrationPosition.position - VRHeadset.position;
                    Debug.Log(temp.magnitude.ToString() + "Adjusting position" + temp.ToString()); ;
                    VRWorldZero.position += temp;
                }
            }
        }
    }
    private void LateUpdate()
    {
        
        if (UseXZYawParenting)
        {
            ZedLocationCar.position = ZedToCarOffset + zedManager.transform.position;
             Vector3 newRotation = new Vector3(
                 ZedLocationCar.eulerAngles.x,
                 zedManager.transform.eulerAngles.y+ ZedToCarYaw,
                 ZedLocationCar.eulerAngles.z);
            ZedLocationCar.eulerAngles = newRotation;
        }
    }
}

