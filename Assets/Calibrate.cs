using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using sl;
public class Calibrate : MonoBehaviour
{

    
    public Transform CallibrationPosition; // SHould be on the center arm rest
    public Transform ZedCameraTracker;
    public Transform VRHeadset;
    public Transform VRWorldZero;


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
        if (zedManager.ZEDTrackingState == sl.TRACKING_STATE.TRACKING_OK && transform.parent==null)
        {

            transform.parent = zedManager.transform;
            Debug.Log(zedManager.ZEDTrackingState + "  " + zedManager.transform.position.y.ToString());
        }
        else if(transform.parent == zedManager.transform)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {

                Quaternion tempRotation = Quaternion.FromToRotation(CallibrationPosition.forward, VRHeadset.forward);
                Debug.Log(tempRotation.eulerAngles.magnitude.ToString() + "Adjusting orientation" + tempRotation.eulerAngles.ToString()); ;
                VRWorldZero.rotation =  tempRotation;


                Vector3 temp = CallibrationPosition.position - VRHeadset.position;
                Debug.Log(temp.magnitude.ToString() + "Adjusting position" + temp.ToString()); ;
                VRWorldZero.position += temp;
            }


        }
    }
}

