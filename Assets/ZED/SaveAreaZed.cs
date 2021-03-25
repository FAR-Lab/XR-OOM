using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAreaZed : MonoBehaviour
{
    public string ZedAreaFilePath = "./";
    ZEDManager mainManager;
    // Start is called before the first frame update
    void Start()
    {
        mainManager = transform.GetComponent<ZEDManager>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyUp(KeyCode.Space))
        {
           
            sl.ERROR_CODE temp = mainManager.zedCamera.SaveCurrentArea(ZedAreaFilePath);
            Debug.Log("I think it worked " + temp.ToString());
        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            Debug.Log("Area saving export stat" + mainManager.zedCamera.GetAreaExportState().ToString());
        }
    }
}
