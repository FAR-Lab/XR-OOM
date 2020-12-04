
//  ==> COPYRIGHT (C) 2020 XSENS TECHNOLOGIES OR SUBSIDIARIES WORLDWIDE <==
//  WARNING: COPYRIGHT (C) 2020 XSENS TECHNOLOGIES OR SUBSIDIARIES WORLDWIDE. ALL RIGHTS RESERVED.
//  THIS FILE AND THE SOURCE CODE IT CONTAINS (AND/OR THE BINARY CODE FILES FOUND IN THE SAME
//  FOLDER THAT CONTAINS THIS FILE) AND ALL RELATED SOFTWARE (COLLECTIVELY, "CODE") ARE SUBJECT
//  TO AN END USER LICENSE AGREEMENT ("AGREEMENT") BETWEEN XSENS AS LICENSOR AND THE AUTHORIZED
//  LICENSEE UNDER THE AGREEMENT. THE CODE MUST BE USED SOLELY WITH XSENS PRODUCTS INCORPORATED
//  INTO LICENSEE PRODUCTS IN ACCORDANCE WITH THE AGREEMENT. ANY USE, MODIFICATION, COPYING OR
//  DISTRIBUTION OF THE CODE IS STRICTLY PROHIBITED UNLESS EXPRESSLY AUTHORIZED BY THE AGREEMENT.
//  IF YOU ARE NOT AN AUTHORIZED USER OF THE CODE IN ACCORDANCE WITH THE AGREEMENT, YOU MUST STOP
//  USING OR VIEWING THE CODE NOW, REMOVE ANY COPIES OF THE CODE FROM YOUR COMPUTER AND NOTIFY
//  XSENS IMMEDIATELY BY EMAIL TO INFO@XSENS.COM. ANY COPIES OR DERIVATIVES OF THE CODE (IN WHOLE
//  OR IN PART) IN SOURCE CODE FORM THAT ARE PERMITTED BY THE AGREEMENT MUST RETAIN THE ABOVE
//  COPYRIGHT NOTICE AND THIS PARAGRAPH IN ITS ENTIRETY, AS REQUIRED BY THE AGREEMENT.
//  
//  THIS SOFTWARE CAN CONTAIN OPEN SOURCE COMPONENTS WHICH CAN BE SUBJECT TO 
//  THE FOLLOWING GENERAL PUBLIC LICENSES:
//  ==> Qt GNU LGPL version 3: http://doc.qt.io/qt-5/lgpl.html <==
//  ==> LAPACK BSD License:  http://www.netlib.org/lapack/LICENSE.txt <==
//  ==> StackWalker 3-Clause BSD License: https://github.com/JochenKalmbach/StackWalker/blob/master/LICENSE <==
//  ==> Icon Creative Commons 3.0: https://creativecommons.org/licenses/by/3.0/legalcode <==
//  

//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace XDA {

public enum XsCanDataIdentifier {
  XCDI_Invalid = 0x00,
  XCDI_Error = 0x01,
  XCDI_Warning = 0x02,
  XCDI_SampleTime = 0x05,
  XCDI_GroupCounter = 0x06,
  XCDI_UtcTime = 0x07,
  XCDI_StatusWord = 0x11,
  XCDI_Quaternion = 0x21,
  XCDI_EulerAngles = 0x22,
  XCDI_RotationMatrix = 0x23,
  XCDI_DeltaV = 0x31,
  XCDI_RateOfTurn = 0x32,
  XCDI_DeltaQ = 0x33,
  XCDI_Acceleration = 0x34,
  XCDI_FreeAcceleration = 0x35,
  XCDI_MagneticField = 0x41,
  XCDI_Temperature = 0x51,
  XCDI_BaroPressure = 0x52,
  XCDI_RateOfTurnHR = 0x61,
  XCDI_AccelerationHR = 0x62,
  XCDI_LatLong = 0x71,
  XCDI_AltitudeEllipsoid = 0x72,
  XCDI_PositionEcef_X = 0x73,
  XCDI_PositionEcef_Y = 0x74,
  XCDI_PositionEcef_Z = 0x75,
  XCDI_Velocity = 0x76,
  XCDI_Latitude = 0x77,
  XCDI_Longitude = 0x78,
  XCDI_GnssSatInfo = 0x79,
  XCDI_EndOfGroup,
  XCDI_HighestIdentifier
}

}
