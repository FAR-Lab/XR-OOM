using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using sl;
public class Calibrate : MonoBehaviour
{

    
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
        //Debug.Log(Quaternion.FromToRotation(TrackedVirtualMarkPosition.transform.forward, TargetFixedPositionMarker.transform.forward).eulerAngles.magnitude);

//        OffsetObject.transform.rotation *=  Quaternion.FromToRotation(TrackedVirtualMarkPosition.transform.forward, TargetFixedPositionMarker.transform.forward);
  //      Debug.Log(Quaternion.FromToRotation(TrackedVirtualMarkPosition.transform.forward, TargetFixedPositionMarker.transform.forward).eulerAngles.magnitude);
    //    Vector3 positionadjust = TargetFixedPositionMarker.transform.position - TrackedVirtualMarkPosition.transform.position;
      //  OffsetObject.transform.position += positionadjust;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && zedManager.ZEDTrackingState == sl.TRACKING_STATE.TRACKING_OK && transform.parent==null)
        {
            transform.position += zedManager.transform.position - ZedLocationCar.position;
            transform.parent = zedManager.transform;
            Debug.Log(zedManager.ZEDTrackingState + "  " + zedManager.transform.position.y.ToString());
        }
        else if(transform.parent == zedManager.transform)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                
                /*
                Vector3 temp = CallibrationPosition.position - VRHeadset.position;
                Debug.Log(temp.magnitude.ToString() + "Adjusting position" + temp.ToString()); ;
                VRWorldZero.position += temp;
                */



                  Quaternion tempRotation = Quaternion.FromToRotation( VRHeadset.forward, CallibrationPosition.forward);
                //Quaternion tempRotation =   CallibrationPosition.rotation * Quaternion.Inverse(VRHeadset.rotation);
                    
                Debug.Log(tempRotation.eulerAngles.magnitude.ToString() + "Adjusting orientation" + tempRotation.eulerAngles.ToString()); ;
                //Vector3 axis;float angle;
                //tempRotation.ToAngleAxis(out angle, out axis);
                // VRWorldZero.RotateAround(CallibrationPosition.position, axis, angle);
                VRWorldZero.rotation = tempRotation* VRWorldZero.rotation ;



                  Vector3   temp = CallibrationPosition.position - VRHeadset.position;
                Debug.Log(temp.magnitude.ToString() + "Adjusting position" + temp.ToString()); ;
                VRWorldZero.position += temp;
            }


        }
    }
}

