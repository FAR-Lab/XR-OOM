using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.XR;
using Varjo.XR;

public class  SimpleLogging: MonoBehaviour
{
   public List<Transform> TrackedObject;
   private string m_Path;
   private float m_LastTime;
   private static float m_Rate = 0.03333333333f;
   private bool m_logging;
   
   private Transform [] InternalArray;
   private StreamWriter writer;
   private Queue<string> OutputLines = new Queue<string>();

   private IEnumerator m_CoroutineHandler;
   
   
  
   //  eye tracking
   
   private List<InputDevice> devices = new List<InputDevice>();
   private InputDevice device;
   private Eyes eyes;
   private XRNode XRNode = XRNode.CenterEye;


   private Vector3 leftEyePosition;
   private Vector3 rightEyePosition;
   private Quaternion leftEyeRotation;
   private Quaternion rightEyeRotation;
   private Vector3 fixationPoint;
   
   public bool LoggingActive
   {
      get { return m_logging; }
   }
   
   public void Start()
   {
      m_LastTime = Time.time;
   }
   
   public void StartRecording (string Participantid, string Condition)
   {
      m_Path = Application.persistentDataPath + Participantid+"_"+Condition+".csv";
      Debug.Log("Start Recording here "+ m_Path);
      writer  = new StreamWriter(m_Path, true);
      m_logging = true;
      string header = GenerateHeadser();
      OutputLines.Enqueue(header);
      m_CoroutineHandler =  WritingTask();
      StartCoroutine(m_CoroutineHandler);
   }


   private  IEnumerator WritingTask()
   {
      while (m_logging)
      {
         if (OutputLines.Count > 0)
         {
            writer.WriteLine(OutputLines.Dequeue());
         }
         yield return null;
      }
   }


   private string GenerateHeadser()
   {

      InternalArray = new Transform[TrackedObject.Count];
      string temp="";
      int counter = 0;
      
      foreach (Transform tf in TrackedObject)
      {
         InternalArray[counter] = tf;
         temp += ReturnVariableNames(tf);
         counter++;
      }

      temp += "Time.deltaTime,Time.Time,Time.FrameCount,";
      
      temp += "leftEyePosition.x" + ',';
      temp += "leftEyePosition.y" + ',';
      temp += "leftEyePosition.z" + ',';

      temp += "leftEyeRotation.eulerAngles.x" + ',';
      temp += "leftEyeRotation.eulerAngles.y" + ',';
      temp += "leftEyeRotation.eulerAngles.z" + ',';
         
         
      temp += "rightEyePosition.x "+ ',';
      temp += "rightEyePosition.y" + ',';
      temp += "rightEyePosition.z "+ ',';

      temp += "rightEyeRotation.eulerAngles.x" + ',';
      temp += "rightEyeRotation.eulerAngles.y" + ',';
      temp += "rightEyeRotation.eulerAngles.z "+ ',';
   
         
      temp += "fixationPoint.x "+ ',';
      temp += "fixationPoint.y" + ',';
      temp += "fixationPoint.z";
      
      
      
      return temp;
   }

   private string ReturnVariableNames(Transform tf)
   {
      string temp = "";
      temp += tf.name + ".pos.x,";
      temp += tf.name + ".pos.y,";
      temp += tf.name + ".pos.z,";
      
      temp += tf.name + ".rot.x,";
      temp += tf.name + ".rot.y,";
      temp += tf.name + ".rot.z,";
      return temp;
   }

   void logData(bool UseEyeData)
   {
      string temp = "";
      foreach (Transform tf in InternalArray)
      {
           temp += tf.position.x.ToString()+',';
           temp += tf.position.y.ToString()+',';
           temp += tf.position.z.ToString()+',';
   
           temp +=  tf.rotation.eulerAngles.x.ToString()+',';
           temp +=  tf.rotation.eulerAngles.y.ToString()+',';
           temp +=  tf.rotation.eulerAngles.z.ToString()+',';
      }

      temp += Time.deltaTime.ToString()+',';
      temp += Time.time.ToString()+',';
      temp += Time.frameCount.ToString()+',';

      if (UseEyeData)
      {
         temp += leftEyePosition.x.ToString() + ',';
         temp += leftEyePosition.y.ToString() + ',';
         temp += leftEyePosition.z.ToString() + ',';

         temp += leftEyeRotation.eulerAngles.x.ToString() + ',';
         temp += leftEyeRotation.eulerAngles.y.ToString() + ',';
         temp += leftEyeRotation.eulerAngles.z.ToString() + ',';
         
         
         temp += rightEyePosition.x.ToString() + ',';
         temp += rightEyePosition.y.ToString() + ',';
         temp += rightEyePosition.z.ToString() + ',';

         temp += rightEyeRotation.eulerAngles.x.ToString() + ',';
         temp += rightEyeRotation.eulerAngles.y.ToString() + ',';
         temp += rightEyeRotation.eulerAngles.z.ToString() + ',';
   
         
         temp += fixationPoint.x.ToString() + ',';
         temp += fixationPoint.y.ToString() + ',';
         temp += fixationPoint.z.ToString();

      }
      else
      {
         for (uint i=0; i < 14; i++) //should be 15 but we dont want the last ,
         {
            temp +=  "N/A"+ ',';
         }
         temp +=  "N/A";
      }
      OutputLines.Enqueue(temp);
   }

   public void Update()
   {

      if (m_logging)
      {
       if (Time.time - m_LastTime >= m_Rate)
       {
          
            logData(GetEyeData());
         }
      }
   }

   private bool GetEyeData()
   {
      bool temp = false;
      if (VarjoEyeTracking.IsGazeAllowed() && VarjoEyeTracking.IsGazeCalibrated())
      {

         if (!device.isValid)
         {
            GetDevice();
         }

         if (device.isValid && device.TryGetFeatureValue(CommonUsages.eyesData, out eyes))
         {
            temp = true;
            bool error = false;
            if (!eyes.TryGetLeftEyePosition(out leftEyePosition)) error = true;
            if (!eyes.TryGetLeftEyeRotation(out leftEyeRotation)) error = true;
            if (!eyes.TryGetRightEyePosition(out rightEyePosition)) error = true;
            if (!eyes.TryGetRightEyeRotation(out rightEyeRotation)) error = true;
            if (!eyes.TryGetFixationPoint(out fixationPoint)) error = true;
            if (error)
            {
               Debug.Log("Something happened with the eye recording :-/");
               temp = false;
            }
         }
      }

      return temp;
   }

   private void OnDestroy()
   {
      if (m_logging)
      {
         StopRecording();
      }
   }

   public void StopRecording()
   {
      m_logging = false;
      StopCoroutine(m_CoroutineHandler);
      Debug.Log("Finishing writing to this fileStill openToDos: "+ OutputLines.Count);
      while(OutputLines.Count>0)
      {
         writer.WriteLine(OutputLines.Dequeue());
      }
      writer.Close();
      writer = null;

   }
    
   
   //Eyes
   
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
}

