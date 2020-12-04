using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calibrate : MonoBehaviour
{
    public GameObject OffsetObject;
    public GameObject Mh;
    public GameObject Mz;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void MoveGameObject()
    {

        OffsetObject.transform.rotation *=  Quaternion.FromToRotation(Mh.transform.forward, Mz.transform.forward);

        Vector3 positionadjust = Mz.transform.position - Mh.transform.position;
        OffsetObject.transform.position += positionadjust;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.X))
        {
            MoveGameObject();
        }
    }
}

