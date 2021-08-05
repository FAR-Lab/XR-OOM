using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(SimpleLogging))]
public class SomeScriptEditor : Editor
{

    private string m_ParticipantID="ParticipantID";
    private string m_Condition="Condition";
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

       // EditorGUILayout.HelpBox("This is a help box", MessageType.Info);
        
        SimpleLogging logger = (SimpleLogging)target;
        if( ! logger.LoggingActive)
        {
            m_ParticipantID = EditorGUILayout.TextArea(m_ParticipantID);
            m_Condition = EditorGUILayout.TextArea(m_Condition);
            
            if(GUILayout.Button("Start Recording")) {
             logger.StartRecording(m_ParticipantID,m_Condition); 
             
            }
         }
        else{
            if(GUILayout.Button("Stop Recording"))
            {
                logger.StopRecording();
            }
            
        }
        
    }
}
