using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Varjo.XR;

public class MarkerManager : MonoBehaviour
{
    private List<VarjoMarker> markers;
    private List<long> markerIds;
    private List<long> absentIds;
    private Dictionary<long, MarkerVisualizer> markerVisualizers;

    public VarjoMarker marker;

    public Transform xrRig;
    public GameObject markerPrefab;

    public bool markersEnabled = true;
    private bool _markersEnabled;

    public long markerTimeout = 3000;
    private long _markerTimeout;

    private VarjoMarker CarCover;
    GameObject CarCoverObj;



    private Transform markerTransform;

    void Start()
    {
        markers = new List<VarjoMarker>();
        markerIds = new List<long>();
        absentIds = new List<long>();
        markerVisualizers = new Dictionary<long, MarkerVisualizer>();
        marker = new VarjoMarker();


        //  CarCoverObj = Instantiate(markerPrefab);
        CarCoverObj = this.gameObject;
    }

    void Update()
    {
        if (markersEnabled != _markersEnabled)
        {
            markersEnabled = VarjoMarkers.EnableVarjoMarkers(markersEnabled);
            _markersEnabled = markersEnabled;
        }

        if (VarjoMarkers.IsVarjoMarkersEnabled())
        {
            markers.Clear();
            markerIds.Clear();
            int foundMarkers = VarjoMarkers.GetVarjoMarkers(out markers);
            if (markers.Count > 0)
            {

                CarCover.pose.position = Vector3.zero;
                CarCover.size = Vector3.zero;
                CarCover.pose.rotation = Quaternion.Euler(Vector3.zero);
                IDictionary<string, Quaternion> markerRotations = new Dictionary<string, Quaternion>();

                foreach (var marker in markers)
                {
                    markerIds.Add(marker.id);
                    CarCover.pose.position += marker.pose.position;
                    CarCover.size += marker.size;

                    //filling out the Dictionary with the quaternions for each marker
                    markerRotations.Add(marker.id.ToString(),marker.pose.rotation); //adding key/value using the Add() method
                    foreach (KeyValuePair<string, Quaternion> kvp in markerRotations)
                        Debug.Log("marker.id, marker.pose.rotation " + kvp.Key + kvp.Value);

                    if (markerVisualizers.ContainsKey(marker.id))
                    {
                        UpdateMarkerVisualizer(marker);
                    }
                    else
                    {
                        CreateMarkerVisualizer(marker);
                        VarjoMarkers.SetVarjoMarkerTimeout(marker.id, markerTimeout);
                    }
                }
                CarCover.pose.position /= markers.Count; //the position of the CarCover object is the average between the marker positions
                CarCover.size /= markers.Count; //this is the case for size as well
                CarCover.pose.rotation = Quaternion.Lerp(markerRotations["303"],markerRotations["308"],0.5f); //rotations of different markers are interpolated here
                

                Debug.Log("test value of marker 303" +markerRotations["303"]);


                if (markerTimeout != _markerTimeout)
                {
                    SetMarkerTimeOuts();
                    _markerTimeout = markerTimeout;
                }

                
            }

            VarjoMarkers.GetRemovedVarjoMarkerIds(out absentIds);

            foreach (var id in absentIds)
            {
                if (markerVisualizers.ContainsKey(id))
                {
                    Destroy(markerVisualizers[id].gameObject);
                    markerVisualizers.Remove(id);
                }
                markerIds.Remove(id);
            }
            absentIds.Clear();
        }

        if (markerIds.Count == 0 && markerVisualizers.Count > 0)
        {
            var ids = markerVisualizers.Keys.ToArray();
            foreach (var id in ids)
            {
                Destroy(markerVisualizers[id].gameObject);
                markerVisualizers.Remove(id);
            }
        }

        CarCoverObj.GetComponent<MarkerVisualizer>().SetMarkerData(CarCover);

        
    }

    void CreateMarkerVisualizer(VarjoMarker marker)
    {
       //GameObject go = Instantiate(markerPrefab);
       //markerTransform = go.transform;
       // go.name = marker.id.ToString();
       //markerTransform.SetParent(xrRig);
       //MarkerVisualizer visualizer = go.GetComponent<MarkerVisualizer>();
       //markerVisualizers.Add(marker.id, visualizer);
       //visualizer.SetMarkerData(marker);
    }

    void UpdateMarkerVisualizer(VarjoMarker marker)
    {
        markerVisualizers[marker.id].SetMarkerData(marker);
    }

    void SetMarkerTimeOuts()
    {
        for (var i = 0; i < markerIds.Count; i++)
        {
            VarjoMarkers.SetVarjoMarkerTimeout(markerIds[i], markerTimeout);
        }
    }
       
}
