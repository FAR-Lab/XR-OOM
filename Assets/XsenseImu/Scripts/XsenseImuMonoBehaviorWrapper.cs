using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XDA;

public class XsenseImuMonoBehaviorWrapper : MonoBehaviour
{

    internal class CallbackHandler : XsCallback
    {
        private uint _maxNumberOfPacketsInBuffer;
        private uint _numberOfPacketsInBuffer;
        private Queue<XsDataPacket> _packetBuffer;
        private object _lockThis;

        private uint MaxNumberOfPacketsInBuffer
        {
            get { return _maxNumberOfPacketsInBuffer; }
            set { _maxNumberOfPacketsInBuffer = value; }
        }

        private uint NumberOfPacketsInBuffer
        {
            get { return _numberOfPacketsInBuffer; }
            set { _numberOfPacketsInBuffer = value; }
        }

        private Queue<XsDataPacket> PacketBuffer
        {
            get { return _packetBuffer; }
            set { _packetBuffer = value; }
        }

        public CallbackHandler(uint maxBufferSize = 5)
            : base()
        {
            MaxNumberOfPacketsInBuffer = maxBufferSize;
            NumberOfPacketsInBuffer = 0;
            PacketBuffer = new Queue<XsDataPacket>();
            _lockThis = new object();
        }

        public bool packetAvailable()
        {
            lock (_lockThis)
                return NumberOfPacketsInBuffer > 0;
        }
        public uint packageCount()
        {
            lock (_lockThis)
                return NumberOfPacketsInBuffer;
        }

        public XsDataPacket getNextPacket()
        {
            Debug.Assert(packetAvailable());
            lock (_lockThis)
            {
                XsDataPacket oldestPacket = PacketBuffer.Peek();
                PacketBuffer.Dequeue();
                --NumberOfPacketsInBuffer;
                return oldestPacket;
            }
        }

        protected override void onLiveDataAvailable(XsDevice dev, XsDataPacket packet)
        {
            lock (_lockThis)
            {
                Debug.Assert(packet != null);
                while (NumberOfPacketsInBuffer >= MaxNumberOfPacketsInBuffer)
                    getNextPacket();

                PacketBuffer.Enqueue(new XsDataPacket(packet));
                ++NumberOfPacketsInBuffer;
                Debug.Assert(NumberOfPacketsInBuffer <= MaxNumberOfPacketsInBuffer);
            }
        }
    }


   
    XsControl control;
    CallbackHandler callback;
    XsPortInfo mtPort;

    public Quaternion Orientation;
    public Vector3 Acceleration;
    public static XsenseImuMonoBehaviorWrapper Instance { get { return _instance; } }
    private static XsenseImuMonoBehaviorWrapper _instance;

    



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
    // Start is called before the first frame update
    void Start()
    {
        control = new XsControl();
        try
        {
            Debug.Log("Scanning for devices...");
            XsPortInfoArray portInfoArray = XsScanner.scanPorts();
            mtPort = new XsPortInfo();
            for (uint i = 0; i < portInfoArray.size(); i++)
            {
                if (portInfoArray.at(i).deviceId().isMti() || portInfoArray.at(i).deviceId().isMtig())
                {
                    mtPort = portInfoArray.at(i);
                    break;
                }
            }

            if (mtPort.empty()) { Debug.LogError("No MTi device found. Aborting."); }

            Debug.Log("Found a device with ID:" + mtPort.deviceId().toXsString().toString());
            Debug.Log("At port:" + mtPort.portName().toString());
            Debug.Log("Baudrate:" + mtPort.baudrate().ToString());

            if (!control.openPort(mtPort.portName(), mtPort.baudrate()))
            {
                Debug.LogError("Could not open port. Aborting.");
            }

            // Get the device object
            XsDevice tempDevice = control.device(mtPort.deviceId());
            Debug.Assert(tempDevice != null);
            XsDevice device = new XsDevice(tempDevice);

            Debug.Log("Device opened:" + device.productCode().toString());

            // Create and attach callback handler to device
            callback = new CallbackHandler(2);
            device.addCallbackHandler(callback);

            Debug.Log("Putting device into measurement mode...");
            if (!device.gotoMeasurement())
            {
                Debug.LogError("Could not put device into measurement mode. Aborting.");
            }

        }
        catch (UnityException exc)
        {
            Debug.Log(exc.ToString());
        }
    }
        // Update is called once per frame
        void Update()
    {
        if (callback.packetAvailable())
        {
            // Retrieve a packet
            XsDataPacket packet = callback.getNextPacket();
            //Debug.Log(callback.packageCount());
            if (packet.containsCalibratedData())
            {
               
                XsVector acc = packet.calibratedAcceleration();
                Acceleration.x = -(float)acc.value(1);
                Acceleration.y = (float)acc.value(2);
                Acceleration.z = (float)acc.value(0);
                // XsVector gyr = packet.calibratedGyroscopeData();
                //                Console.Write(" |Gyr X:{0,-5:f2}, Gyr Y:{1,-5:f2}, Gyr Z:{2,-5:f2}", gyr.value(0), gyr.value(1), gyr.value(2));

                //XsVector mag = packet.calibratedMagneticField();
                //              //Console.Write(" |Mag X:{0,-5:f2}, Mag Y:{1,-5:f2}, Mag Z:{2,-5:f2}", mag.value(0), mag.value(1), mag.value(2));
            }

            if (packet.containsOrientation())
            {
                //Debug.Log("Orientation Avalible");

               // XsQuaternion quaternion = packet.orientationQuaternion();
                //Console.Write("\rq0:{0,-5:f2}, q1:{1,-5:f2}, q2:{2,-5:f2}, q3:{3,-5:f2}", quaternion.w(), quaternion.x(), quaternion.y(), quaternion.z());
                //transform.rotation = new Quaternion ((float)quaternion.x(), (float)quaternion.y(), (float)quaternion.z(), (float)quaternion.w());
                XsEuler euler = packet.orientationEuler();
                Orientation =  Quaternion.Euler((float)euler.pitch(), -(float)euler.yaw(),-(float) euler.roll());
                //Console.Write(" |Roll:{0,-5:f2}, Pitch:{1,-5:f2}, Yaw:{2,-5:f2}", euler.roll(), euler.pitch(), euler.yaw());
            }
            /*
            if (packet.containsLatitudeLongitude())
            {
                XsVector latLon = packet.latitudeLongitude();
                //Console.Write(" |Lat:{0,-5:f2}, Lon:{1,-5:f2}", latLon.value(0), latLon.value(1));
            }

            if (packet.containsAltitude())
            {
               // Console.Write(" |Alt:{0,-5:f2}", packet.altitude());
            }


            if (packet.containsVelocity())
            {
                XsVector vel = packet.velocity(XsDataIdentifier.XDI_CoordSysEnu);
               // Console.Write(" |E:{0,-5:f2}, N:{1,-5:f2}, U:{2,-5:f2}", vel.value(0), vel.value(1), vel.value(2));
            }*/

            packet.Dispose();
        }
        else
        {
            Debug.Log("Did Not Get a package");
        }
    }
    private void OnApplicationQuit()
    {
        
        control.closePort(mtPort.portName());
        control.close();


    }
}
