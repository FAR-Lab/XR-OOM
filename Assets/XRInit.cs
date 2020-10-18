using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRInit : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        Varjo.XR.VarjoMixedReality.StartRender();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
