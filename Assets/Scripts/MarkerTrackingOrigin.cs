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

    public GameObject rootMarker;

    private Vector3 _averagePosition;
    private Quaternion _averageRotation;
    private List<VarjoMarker> _markers = new List<VarjoMarker>();

    private void Awake() {
        Instance = this;
    }

    public void Update() {
        if (VarjoEventManager.Instance.GetButtonDown(0) && VarjoMixedReality.IsMRAvailable()) {
            bool enable = !VarjoMarkers.IsVarjoMarkersEnabled();
            VarjoMarkers.EnableVarjoMarkers(enable);

            if (enable)
                OnMarkersActiveEvent.Invoke();
            else
                OnMarkersDisabledEvent();

            if (VarjoMarkers.GetVarjoMarkerCount() > 0) {
                rootMarker.SetActive(true);
            }
        }


        if (!VarjoMarkers.IsVarjoMarkersEnabled()) {
            rootMarker.SetActive(!disableWhenMarkerNotVisible);
            return;
        }

        // This simply averages the marker positions of any that are detected
        _markers.Clear();
        VarjoMarkers.GetVarjoMarkers(out _markers);

        if (_markers.Count > 0) {
            _averagePosition = Vector3.zero;
            _averageRotation = Quaternion.identity;

            foreach(var marker in _markers) {
                _averagePosition += marker.pose.position;
                _averageRotation = marker.pose.rotation;
            }
            _averagePosition /= _markers.Count;

            Vector3 euler = _averageRotation.eulerAngles;

            transform.position = Vector3.Lerp(transform.position, _averagePosition, Time.deltaTime * lerpRate);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0f, euler.y, 0f), Time.deltaTime * lerpRate);
        }
    }
}