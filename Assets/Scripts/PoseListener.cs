using UnityEngine;
using RosPose = RosMessageTypes.Geometry.PoseStamped;
[RequireComponent (typeof(ROSConnection))]
public class PoseListener : MonoBehaviour
{
    private ROSConnection ros;
    public GameObject cube;

    public Vector3 position;
    public Quaternion orientation;
    public readonly string address = "/zedm/zed_node/pose";

    public static PoseListener Instance { get { return _instance; } }
    private static PoseListener _instance;

    public delegate void NewPoseDeleGate(Vector3 pos, Quaternion rot);
    public NewPoseDeleGate callDelegates=null;
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    void Start()
    {
        ros = transform.GetComponent<ROSConnection>();
        ros.Subscribe<RosPose>(address, PoseChange);
        
    }

    void PoseChange(RosPose poseMessage)
    {
        //cube.transform.position 
            position = TransformExtensions.Ros2Unity(new Vector3((float)poseMessage.pose.position.x,
           (float)poseMessage.pose.position.y,
         (float)poseMessage.pose.position.z
          ));

        //cube.transform.rotation 
          orientation = TransformExtensions.Ros2Unity(new Quaternion((float)poseMessage.pose.orientation.x,
           (float)poseMessage.pose.orientation.y,
         (float)poseMessage.pose.orientation.z,
         (float)poseMessage.pose.orientation.w
          ));
        callDelegates(position, orientation);

        //cube.transform.position = new Vector3(
        //    (float)poseMessage.pose.position.z,
        //    -(float)poseMessage.pose.position.x,
        //    (float)poseMessage.pose.position.y
        //    );
    }
}