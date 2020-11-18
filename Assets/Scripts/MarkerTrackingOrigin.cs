using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Varjo.XR;






public class MarkerTrackingOrigin : MonoBehaviour {
    public static MarkerTrackingOrigin Instance { get; private set; } = null;
    public float lerpRate = 2.0f;
    public bool disableWhenMarkerNotVisible = false;

    public delegate void MarkersActive();
    public static MarkersActive OnMarkersActiveEvent;

    public delegate void MarkersDisabled();
    public static MarkersDisabled OnMarkersDisabledEvent;

    public Transform rootMarker;

    private Vector3 _averagePosition;
    private Quaternion _averageRotation;
    private List<VarjoMarker> _markers = new List<VarjoMarker>();
    
    
    public Dictionary<long, Vector3> MarkerOffsets = new Dictionary<long, Vector3>();

    public long MarkerA;
    public long MarkerB;


    private void Awake() {
        Instance = this;
    }
    private void Start()
    {
        VarjoMarkers.EnableVarjoMarkers(true);

        MarkerOffsets.Add(310, new Vector3(-0.3f, 0.3f, 0));
        MarkerOffsets.Add(309, new Vector3(0.3f, -0.3f, 0));

    }

    public void Update() {
        if ((Input.GetKeyDown(KeyCode.Space) || VarjoEventManager.Instance.GetButtonDown(0)) && VarjoMixedReality.IsMRAvailable()) {
            bool enable = !VarjoMarkers.IsVarjoMarkersEnabled();
            VarjoMarkers.EnableVarjoMarkers(enable);

            if (enable)
                OnMarkersActiveEvent.Invoke();
            else
                OnMarkersDisabledEvent();

            if (VarjoMarkers.GetVarjoMarkerCount() > 0) {
                rootMarker.gameObject.SetActive(true);
            }
        }


        if (!VarjoMarkers.IsVarjoMarkersEnabled()) {
            rootMarker.gameObject.SetActive(!disableWhenMarkerNotVisible);
            return;
        }

        // This simply averages the marker positions of any that are detected
        _markers.Clear();
        VarjoMarkers.GetVarjoMarkers(out _markers);

        if (_markers.Count > 0) {
            _averagePosition = Vector3.zero;
            _averageRotation = Quaternion.identity;

            bool MarkerAAvail=false;
            bool MarkerBAvail=false;
            Vector3 MarkerAPos = Vector3.zero;
            Vector3 MarkerBPos = Vector3.zero;
            foreach (var marker in _markers) {
                if (MarkerOffsets.ContainsKey(marker.id))
                {
                    _averagePosition += marker.pose.position - MarkerOffsets[marker.id];
                    _averageRotation = marker.pose.rotation;
                    //Debug.Log(marker.id);
                }
                if (marker.id == MarkerA)
                {
                    MarkerAAvail = true;
                    MarkerAPos = marker.pose.position;
                }
                else if (marker.id == MarkerB)
                {
                    MarkerBAvail = true;
                    MarkerBPos = marker.pose.position;
                }
            }
            Vector3 Forward = Vector3.zero;
            if (MarkerAAvail && MarkerBAvail)
            {

                Vector3 WidthVector = MarkerBPos - MarkerAPos;
                WidthVector.y = 0;
                Forward = Vector3.Cross(Vector3.up, WidthVector);

            }


            _averagePosition /= _markers.Count;
           // Debug.Log(_averagePosition.ToString() + ": pos and Marker count" + _markers.Count.ToString());
           
            Vector3 euler = _averageRotation.eulerAngles;

            rootMarker.position = Vector3.Lerp(rootMarker.position, _averagePosition, Time.deltaTime * lerpRate);
            //rootMarker.rotation = Quaternion.Lerp(rootMarker.rotation, Quaternion.Euler(0f, euler.y, 0f), Time.deltaTime * lerpRate);
            rootMarker.rotation = Quaternion.Lerp(rootMarker.rotation, Quaternion.FromToRotation(rootMarker.forward, Forward), Time.deltaTime* lerpRate);
        }
    }
}