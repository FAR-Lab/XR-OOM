using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Varjo.XR;
[RequireComponent(typeof(ROSConnection))]
public class HMDLogger : MonoBehaviour
{

    public ROSConnection ros;
    public string topicName = "hmd";

    Transform Camera;
   
    void Start()
    {
        ros = transform.GetComponent<ROSConnection>();
        Camera = FindObjectOfType<VarjoMR>().XRCamera.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
       RosMessageTypes.Geometry.Pose tempMsg = new RosMessageTypes.Geometry.Pose();
        Vector3 posTemp = Camera.position.Unity2Ros();
        Quaternion rotTemp = Camera.rotation.Unity2Ros();
        tempMsg.position = new RosMessageTypes.Geometry.Point(posTemp.x, posTemp.y, posTemp.z);
        tempMsg.orientation = new RosMessageTypes.Geometry.Quaternion(rotTemp.x, rotTemp.y, rotTemp.z, rotTemp.w);
        ros.Send(topicName, tempMsg);
        
    }
}
