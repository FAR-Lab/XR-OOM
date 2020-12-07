using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Varjo.XR;

public class SimpleMarkerManager : MonoBehaviour
{
    private List<VarjoMarker> _markers = new List<VarjoMarker>();
    private void Start()
    {
 
    }

    void Update()
    {
        
        if (VarjoMixedReality.IsMRAvailable())
        {
            if (Input.GetKeyDown(KeyCode.X)) { VarjoMarkers.EnableVarjoMarkers(true); }
            else if (Input.GetKey(KeyCode.X))
            {
                _markers.Clear();
                VarjoMarkers.GetVarjoMarkers(out _markers);

                foreach (var marker in _markers)
                {
                    if (marker.id == 200)
                    {
                        transform.localPosition = marker.pose.position; //changed to direct local association transform instead of 
                    }
                }
            }
            else if (Input.GetKeyUp(KeyCode.X)) { VarjoMarkers.EnableVarjoMarkers(false); }
            else
            {
                if (VarjoMarkers.IsVarjoMarkersEnabled())
                {
                    VarjoMarkers.EnableVarjoMarkers(false);
                }
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