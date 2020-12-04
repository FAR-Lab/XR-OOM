using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using Varjo.XR;
[RequireComponent(typeof(ROSConnection))]
public class GazeToRosLogger : MonoBehaviour
{

    public ROSConnection ros;
    public string topicName = "gaze";


    private List<InputDevice> devices = new List<InputDevice>();
    private InputDevice device;
    private Eyes eyes;
    public XRNode XRNode = XRNode.CenterEye;


    private Vector3 leftEyePosition;
    private Vector3 rightEyePosition;
    private Quaternion leftEyeRotation;
    private Quaternion rightEyeRotation;
    private Vector3 fixationPoint;

    RosMessageTypes.Logging.Gazetracking message;

    // Start is called before the first frame update
    void Start()
    {
        ros = transform.GetComponent<ROSConnection>();
        message = new RosMessageTypes.Logging.Gazetracking();
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

        if (VarjoEyeTracking.IsGazeAllowed() && VarjoEyeTracking.IsGazeCalibrated())
        {

            if (!device.isValid)
            {
                GetDevice();
            }
            if (device.TryGetFeatureValue(CommonUsages.eyesData, out eyes))
            {

                if (eyes.TryGetLeftEyePosition(out leftEyePosition))
                {
                    message.left_position_x = leftEyePosition.x;
                    message.left_position_y = leftEyePosition.y;
                    message.left_position_z = leftEyePosition.z;
                }

                if (eyes.TryGetLeftEyeRotation(out leftEyeRotation))
                {
                    message.left_rotation_x = leftEyeRotation.x;
                    message.left_rotation_y = leftEyeRotation.y;
                    message.left_rotation_z = leftEyeRotation.z;
                    message.left_rotation_w = leftEyeRotation.w;
                }

                if (eyes.TryGetRightEyePosition(out rightEyePosition))
                {
                    message.right_position_x = rightEyePosition.x;
                    message.right_position_y = rightEyePosition.y;
                    message.right_position_z = rightEyePosition.z;
                }

                if (eyes.TryGetRightEyeRotation(out rightEyeRotation))
                {
                    message.right_rotation_x = rightEyeRotation.x;
                    message.right_rotation_y = rightEyeRotation.y;
                    message.right_rotation_z = rightEyeRotation.z;
                    message.right_rotation_w = rightEyeRotation.w;
                }

                if (eyes.TryGetFixationPoint(out fixationPoint))
                {
                    message.fix_position_x = fixationPoint.x;
                    message.fix_position_y = fixationPoint.y;
                    message.fix_position_z = fixationPoint.z;
                }
                message.game_time = Time.time;
                ros.Send(topicName, message);
            }
        }
    }
}
