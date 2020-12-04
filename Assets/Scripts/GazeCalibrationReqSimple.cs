// Copyright 2019 Varjo Technologies Oy. All rights reserved.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Varjo.XR;

    public class GazeCalibrationReqSimple : MonoBehaviour
    {
       

        [Header("Keyboard key to request calibration")]
        public KeyCode key = KeyCode.F1;

       
        void Update()
        {
           
                if (Input.GetKeyDown(key))
                {
                    RequestGazeCalibration();
                }
          

        }

        void RequestGazeCalibration()
        {
                Varjo.XR.VarjoEyeTracking.RequestGazeCalibration();
           
        }
    }
