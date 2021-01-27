using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Varjo.XR;


public class GroundMarkerManager : MonoBehaviour
{
    private bool DEBUG = true;
    public GameObject CubeL;
    public GameObject CubeR;
    public GameObject CubeF;
    public Transform GroundPlane;
    private List<VarjoMarker> _markers = new List<VarjoMarker>();
    private void Start()
    {

    }

    void Update()
    {

        if (VarjoMixedReality.IsMRAvailable() || DEBUG )
        {
            if (Input.GetKeyDown(KeyCode.Y)) { VarjoMarkers.EnableVarjoMarkers(true); }
            else if (Input.GetKey(KeyCode.Y))
            {
                _markers.Clear();
                VarjoMarkers.GetVarjoMarkers(out _markers);

                foreach (var marker in _markers)
                {
                    if (marker.id == 301)
                    {
                        //transform.localPosition = marker.pose.position; //changed to direct local association transform instead of 
                        CubeL.transform.localPosition = marker.pose.position; //left marker
                    }
                    if (marker.id == 302)
                    {
                        //transform.localPosition = marker.pose.position; //changed to direct local association transform instead of 
                        CubeR.transform.localPosition = marker.pose.position; //right marker
                    }
                    if (marker.id == 300)
                    {
                        //transform.localPosition = marker.pose.position; //changed to direct local association transform instead of 
                        CubeF.transform.localPosition = marker.pose.position; //far ahead marker
                    }
                }
            }
            else if (Input.GetKeyUp(KeyCode.Y)) { VarjoMarkers.EnableVarjoMarkers(false); }
            else
            {
                if (VarjoMarkers.IsVarjoMarkersEnabled())
                {
                    VarjoMarkers.EnableVarjoMarkers(false);
                }
                Debug.Log("Tried to move ground plane"+ CubeL.transform.position.ToString());
                Plane temp = new Plane();
                //GroundPlane.position = (CubeL.transform.position + CubeF.transform.position + CubeR.transform.position) / 3; //setting to average position
                GroundPlane.position = (CubeF.transform.position); //setting to furthest cube position
                temp.Set3Points(CubeL.transform.position, CubeF.transform.position, CubeR.transform.position);
                GroundPlane.rotation = Quaternion.FromToRotation(transform.up, temp.normal);
            }
        }

        /*
        if (VarjoMarkers.IsVarjoMarkersEnabled())
        {
            _markers.Clear();
            VarjoMarkers.GetVarjoMarkers(out _markers);

            foreach (var marker in _markers)
            {
                // Debug.Log(marker.id);
                //Debug.Log(marker.pose.position);
                if (marker.id == 200)
                {
                    transform.localPosition = marker.pose.position; //changed to direct local association transform instead of 
                }
            }
        }
        */
    }
}
