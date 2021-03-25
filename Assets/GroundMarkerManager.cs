using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Varjo.XR;


public class GroundMarkerManager : MonoBehaviour
{
    
    public GameObject CubeL;
    public GameObject CubeR;
    public GameObject CubeF;

    private List<Vector3> PosL;
    private List<Vector3> PosC;
    private List<Vector3> PosR;

    public Transform GroundPlane;
    private List<VarjoMarker> _markers = new List<VarjoMarker>();

    bool TrackerEnable = false;
    bool _trackerEnabled;
    private void Start()
    {
        
    }

    void Update()
    {
        if (VarjoMixedReality.IsMRAvailable())
        {
            if (Input.GetKeyDown(KeyCode.Y)) { VarjoMarkers.EnableVarjoMarkers(true);
                PosL = new List<Vector3>() ;
                PosC = new List<Vector3>(); 
                PosR = new List<Vector3>();
            }
            else if (Input.GetKey(KeyCode.Y))
            {
                _markers.Clear();
                VarjoMarkers.GetVarjoMarkers(out _markers);

                foreach (var marker in _markers)
                {
                    if (marker.id == 300)
                    {
                        //transform.localPosition = marker.pose.position; //changed to direct local association transform instead of 
                        
                        CubeL.transform.localPosition = marker.pose.position; //left marker
                        PosL.Add( marker.pose.position);
                    }
                    if (marker.id == 301)
                    {
                        //transform.localPosition = marker.pose.position; //changed to direct local association transform instead of 
                        CubeR.transform.localPosition = marker.pose.position; //left marker
                        PosC.Add(marker.pose.position);
                    }
                    if (marker.id == 302)
                    {
                        //transform.localPosition = marker.pose.position; //changed to direct local association transform instead of 
                        CubeF.transform.localPosition = marker.pose.position; //far ahead marker
                        PosR.Add(marker.pose.position);
                        
                    }
                }
                //Debug.Log("Tried to move ground plane" + CubeL.transform.position.ToString());
                
            }
            else if (Input.GetKeyUp(KeyCode.Y)) { 
                VarjoMarkers.EnableVarjoMarkers(false);
                
                Plane temp = new Plane();

                Vector3 LPosAvg = Vector3.zero;
                Vector3 CPosAvg = Vector3.zero;
                Vector3 RPosAvg = Vector3.zero;

                foreach (Vector3 L in PosL)
                {
                    LPosAvg += L;
                }
                LPosAvg /= PosL.Count;

                foreach (Vector3 C in PosC)
                {
                    CPosAvg += C;
                }
                CPosAvg /= PosC.Count;

                foreach (Vector3 R in PosR)
                {
                    RPosAvg += R;
                }
                RPosAvg /= PosR.Count;

                GroundPlane.position = (CubeF.transform.position); //setting to furthest cube position
                temp.Set3Points(LPosAvg, CPosAvg, RPosAvg);
                Quaternion rot =  Quaternion.FromToRotation(transform.up, temp.normal);

                GroundPlane.rotation = rot;
                Transform worldZero = FindObjectOfType<Calibrate>().transform; // this is very dirty fix in the future... Thanks David!! 

                worldZero.rotation = Quaternion.FromToRotation(worldZero.up, temp.normal);
            }
            /*else
            {
                if (VarjoMarkers.IsVarjoMarkersEnabled())
                {
                    VarjoMarkers.EnableVarjoMarkers(false);
                }
            }*/


        }

    }
}