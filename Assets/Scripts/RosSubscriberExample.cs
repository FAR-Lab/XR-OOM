using UnityEngine;
using RosColor = RosMessageTypes.RoboticsDemo.UnityColor;

public class RosSubscriberExample : MonoBehaviour
{
    public ROSConnection ros;
    public GameObject cube;

    void Start()
    {
        ros.Subscribe<RosColor>("thisisatest", ColorChange);
    }

    void ColorChange(RosColor colorMessage)
    {
        Debug.Log(colorMessage);
        cube.GetComponent<Renderer>().material.color = new Color32((byte)colorMessage.r, (byte)colorMessage.g, (byte)colorMessage.b, (byte)colorMessage.a);
    
    }
}