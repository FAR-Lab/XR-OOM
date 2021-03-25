using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Varjo.XR;


public class MarkerGrouping : MonoBehaviour
{
    [SerializeField]
    public KeyCode keyPress;
    [SerializeField]
    public int Marker1;
    [SerializeField]
    public int Marker2;
    [SerializeField]
    public int Marker3;

    private List<Vector3> PosL;
    private List<Vector3> PosC;
    private List<Vector3> PosR;

    private List<Vector3> Forward; 


    Calibrate cali;

    private List<VarjoMarker> _markers = new List<VarjoMarker>();

    public Transform A;
    public Transform B;
    public Transform C;
    // Start is called before the first frame update
    void Start()
    {
        cali = FindObjectOfType<Calibrate>();
    }

    // Update is called once per frame
    void Update()
    {
        if (VarjoMixedReality.IsMRAvailable())
        {
            if (Input.GetKeyDown(keyPress))
            {
                VarjoMarkers.EnableVarjoMarkers(true);
                PosL = new List<Vector3>();
                PosC = new List<Vector3>();
                PosR = new List<Vector3>();
                Forward = new List<Vector3>();
            }
            else if (Input.GetKey(keyPress))
            {
                _markers.Clear();
                VarjoMarkers.GetVarjoMarkers(out _markers);

                foreach (var marker in _markers)
                {
                    if (marker.id == Marker1)
                    {
                        //transform.localPosition = marker.pose.position; //changed to direct local association transform instead of 

                        Forward.Add(-marker.pose.up);
                        PosL.Add(marker.pose.position);
                        Debug.DrawLine(marker.pose.position, marker.pose.position - marker.pose.up, Color.red, 1f);
                    }
                    if (marker.id == Marker2)
                    {
                        //transform.localPosition = marker.pose.position; //changed to direct local association transform instead of 
                        Forward.Add(-marker.pose.up);
                        PosC.Add(marker.pose.position);
                        Debug.DrawLine(marker.pose.position, marker.pose.position - marker.pose.up, Color.red, 1f);
                    }
                    if (marker.id == Marker3)
                    {
                        //transform.localPosition = marker.pose.position; //changed to direct local association transform instead of 
                        Forward.Add(-marker.pose.up);
                        PosR.Add(marker.pose.position);
                        Debug.DrawLine(marker.pose.position, marker.pose.position - marker.pose.up, Color.red, 1f);
                    }
                }
                //Debug.Log("Tried to move ground plane" + CubeL.transform.position.ToString());

            }
            else if (Input.GetKeyUp(keyPress))
            {
                if (PosL.Count > 1 && PosC.Count > 1 && PosR.Count > 1)
                {
                    VarjoMarkers.EnableVarjoMarkers(false);

                    Plane temp = new Plane();

                    Vector3 LPosAvg = Vector3.zero;
                    Vector3 CPosAvg = Vector3.zero;
                    Vector3 RPosAvg = Vector3.zero;
                    Vector3 FowAvg = Vector3.zero;

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


                    foreach (Vector3 F in Forward)
                    {
                        FowAvg += F;
                    }
                    FowAvg /= Forward.Count;
                    A.localPosition = LPosAvg;
                    B.localPosition = CPosAvg;
                    C.localPosition = RPosAvg;
                    temp.Set3Points(LPosAvg, CPosAvg, RPosAvg);
                    transform.localRotation = Quaternion.LookRotation(FowAvg, temp.normal);
                    Debug.DrawLine(CPosAvg, CPosAvg + temp.normal, Color.blue, 10f);
                    

                    //transform.rotation = Quaternion.FromToRotation(transform.up, temp.normal);
                    //transform.rotation = Quaternion.FromToRotation(transform.forward, FowAvg);
                    transform.localPosition = CPosAvg;
                    cali.MoveGameObject();
                }
                else
                {
                    PosL.Clear();
                    PosC.Clear();
                    PosR.Clear();
                }

            }


        }
    }
}
