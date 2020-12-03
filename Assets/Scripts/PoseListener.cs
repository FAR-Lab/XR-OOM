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
        cube.transform.position = TransformExtensions.Ros2Unity(new Vector3((float)poseMessage.pose.position.x,
           (float)poseMessage.pose.position.y,
         (float)poseMessage.pose.position.z
          ));

        cube.transform.rotation = TransformExtensions.Ros2Unity(new Quaternion((float)poseMessage.pose.orientation.x,
           (float)poseMessage.pose.orientation.y,
         (float)poseMessage.pose.orientation.z,
         (float)poseMessage.pose.orientation.w
          ));

        //cube.transform.position = new Vector3(
        //    (float)poseMessage.pose.position.z,
        //    -(float)poseMessage.pose.position.x,
        //    (float)poseMessage.pose.position.y
        //    );
    }
}