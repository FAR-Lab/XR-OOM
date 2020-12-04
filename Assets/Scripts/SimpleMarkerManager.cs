using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Varjo.XR;

public class SimpleMarkerManager : MonoBehaviour
{
    private List<VarjoMarker> _markers = new List<VarjoMarker>();
    //public Transform rootMarker;

    private void Start()
    {
        VarjoMarkers.EnableVarjoMarkers(true);
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || VarjoEventManager.Instance.GetButtonDown(0)) && VarjoMixedReality.IsMRAvailable())
        {
            bool enable = !VarjoMarkers.IsVarjoMarkersEnabled();
            VarjoMarkers.EnableVarjoMarkers(enable);

        }

        if (VarjoMarkers.IsVarjoMarkersEnabled())
        {
            _markers.Clear();
            VarjoMarkers.GetVarjoMarkers(out _markers);

            foreach (var marker in _markers)
            {
                // Debug.Log(marker.id);
                //Debug.Log(marker.pose.position);
                if (marker.id == 310)
                {
                    transform.localPosition = marker.pose.position; //changed to direct local association transform instead of 
                }
            }
        }







    }
}