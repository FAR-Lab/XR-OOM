using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionFusion : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 PlanarVelocity;

    Quaternion yawOffset;
    Vector3 ZedPos;
    Quaternion ZedRot;
    bool NewZedData;
    void Start()
    {
        PoseListener.Instance.callDelegates += PoseRecieveDelegateCall;
    }
    public void  PoseRecieveDelegateCall(Vector3 pos, Quaternion rot)
    {
        ZedPos = pos;
        ZedRot = rot;

        NewZedData = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(XsenseImuMonoBehaviorWrapper.Instance != null){
            //transform.rotation = XsenseImuMonoBehaviorWrapper.Instance.Orientation;
            //XsenseImuMonoBehaviorWrapper.Instance.Acceleration;
           
        }
        if (NewZedData)
        {
            NewZedData = false;
            ZedPos.y = 0.815f;
            transform.position = ZedPos;
           
            transform.rotation = Quaternion.Euler(transform.rotation.x, ZedRot.eulerAngles.y, transform.rotation.z);
            yawOffset = ZedRot* Quaternion.Inverse(XsenseImuMonoBehaviorWrapper.Instance.Orientation);
        }
        
        transform.rotation = XsenseImuMonoBehaviorWrapper.Instance.Orientation * yawOffset;
          

        //TODO: Add can bus speed from the vehicle...
        //TODO: Probably more

    }
    void OnDrawGizmos()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.blue;

        Gizmos.DrawRay(transform.position, transform.forward*25);
        Gizmos.color = Color.red;

        Gizmos.DrawRay(transform.position, transform.right * 25);
        Gizmos.color = Color.green;

        Gizmos.DrawRay(transform.position, transform.up * 25);
    }
}
