using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

using Varjo.XR;
[RequireComponent(typeof(ROSConnection))]
public class HMDLogger : MonoBehaviour
{

    public ROSConnection ros;
    public string topicName = "hmd";

    Transform Camera;


    public XRNode XRNode = XRNode.Head;
    private List<InputDevice> devices = new List<InputDevice>();
    private InputDevice device;

    private List<XRNodeState> nodeStates = new List<XRNodeState>();



    void Start()
    {
        ros = transform.GetComponent<ROSConnection>();
        Camera = FindObjectOfType<VarjoMR>().XRCamera.transform;
    }
    void GetDevice()
    {
        InputDevices.GetDevicesAtXRNode(XRNode, devices);
        device = devices.FirstOrDefault();
    }

    void OnEnable()
    {
        if (!device.isValid)
        {
            GetDevice();
        }
    }

    // Update is called once per frame
    void Update()
    {
        InputTracking.GetNodeStates(nodeStates);
        var headState = nodeStates.FirstOrDefault(node => node.nodeType == XRNode.Head);
        if (headState.tracked)
        {
            RosMessageTypes.Geometry.Pose tempMsg = new RosMessageTypes.Geometry.Pose();
            Vector3 posTemp;
            Quaternion rotTemp;
            headState.TryGetPosition(out posTemp);
            headState.TryGetRotation(out rotTemp);
            tempMsg.position = new RosMessageTypes.Geometry.Point(posTemp.x, posTemp.y, posTemp.z);
            tempMsg.orientation = new RosMessageTypes.Geometry.Quaternion(rotTemp.x, rotTemp.y, rotTemp.z, rotTemp.w);
            ros.Send(topicName, tempMsg);
        }
    }
}
