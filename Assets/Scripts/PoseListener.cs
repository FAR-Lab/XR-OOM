using UnityEngine;
using RosPose = RosMessageTypes.Geometry.PoseStamped;

public class PoseListener : MonoBehaviour
{
    public ROSConnection ros;
    public GameObject cube;

    void Start()
    {
        ros.Subscribe<RosPose>("/zedm/zed_node/pose", PoseChange);
    }

    void PoseChange(RosPose poseMessage)
    {
        Debug.Log(poseMessage);
        cube.transform.position = new Vector3(
            (float)poseMessage.pose.position.x,
            (float)poseMessage.pose.position.y,
            (float)poseMessage.pose.position.z
            );
    }
}