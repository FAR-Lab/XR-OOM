
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

public class XsPortInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsPortInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsPortInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsPortInfo() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          xsensdeviceapiPINVOKE.delete_XsPortInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public XsPortInfo() : this(xsensdeviceapiPINVOKE.new_XsPortInfo__SWIG_0(), true) {
  }

  public XsPortInfo(XsString portname, XsBaudRate baudRate, XsPortLinesOptions linesOptions) : this(xsensdeviceapiPINVOKE.new_XsPortInfo__SWIG_1(XsString.getCPtr(portname), (int)baudRate, (int)linesOptions), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsPortInfo(XsString portname, XsBaudRate baudRate) : this(xsensdeviceapiPINVOKE.new_XsPortInfo__SWIG_2(XsString.getCPtr(portname), (int)baudRate), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsPortInfo(XsString portname) : this(xsensdeviceapiPINVOKE.new_XsPortInfo__SWIG_3(XsString.getCPtr(portname)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsPortInfo(int portNr, XsBaudRate baudRate, XsPortLinesOptions linesOptions) : this(xsensdeviceapiPINVOKE.new_XsPortInfo__SWIG_4(portNr, (int)baudRate, (int)linesOptions), true) {
  }

  public XsPortInfo(int portNr, XsBaudRate baudRate) : this(xsensdeviceapiPINVOKE.new_XsPortInfo__SWIG_5(portNr, (int)baudRate), true) {
  }

  public XsPortInfo(int portNr) : this(xsensdeviceapiPINVOKE.new_XsPortInfo__SWIG_6(portNr), true) {
  }

  public void clear() {
    xsensdeviceapiPINVOKE.XsPortInfo_clear(swigCPtr);
  }

  public bool empty() {
    bool ret = xsensdeviceapiPINVOKE.XsPortInfo_empty(swigCPtr);
    return ret;
  }

  public int portNumber() {
    int ret = xsensdeviceapiPINVOKE.XsPortInfo_portNumber(swigCPtr);
    return ret;
  }

  public XsString portName() {
    XsString ret = new XsString(xsensdeviceapiPINVOKE.XsPortInfo_portName(swigCPtr), true);
    return ret;
  }

  public string portName_c_str() {
    string ret = xsensdeviceapiPINVOKE.XsPortInfo_portName_c_str(swigCPtr);
    return ret;
  }

  public void setPortName(XsString portName_) {
    xsensdeviceapiPINVOKE.XsPortInfo_setPortName(swigCPtr, XsString.getCPtr(portName_));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool isUsb() {
    bool ret = xsensdeviceapiPINVOKE.XsPortInfo_isUsb(swigCPtr);
    return ret;
  }

  public bool isNetwork() {
    bool ret = xsensdeviceapiPINVOKE.XsPortInfo_isNetwork(swigCPtr);
    return ret;
  }

  public XsString networkServiceName() {
    XsString ret = new XsString(xsensdeviceapiPINVOKE.XsPortInfo_networkServiceName(swigCPtr), true);
    return ret;
  }

  public int usbBus() {
    int ret = xsensdeviceapiPINVOKE.XsPortInfo_usbBus(swigCPtr);
    return ret;
  }

  public int usbAddress() {
    int ret = xsensdeviceapiPINVOKE.XsPortInfo_usbAddress(swigCPtr);
    return ret;
  }

  public XsBaudRate baudrate() {
    XsBaudRate ret = (XsBaudRate)xsensdeviceapiPINVOKE.XsPortInfo_baudrate(swigCPtr);
    return ret;
  }

  public void setBaudrate(XsBaudRate baudrate_) {
    xsensdeviceapiPINVOKE.XsPortInfo_setBaudrate(swigCPtr, (int)baudrate_);
  }

  public XsDeviceId deviceId() {
    XsDeviceId ret = new XsDeviceId(xsensdeviceapiPINVOKE.XsPortInfo_deviceId(swigCPtr), true);
    return ret;
  }

  public void setDeviceId(XsDeviceId deviceId_) {
    xsensdeviceapiPINVOKE.XsPortInfo_setDeviceId(swigCPtr, XsDeviceId.getCPtr(deviceId_));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsPortLinesOptions linesOptions() {
    XsPortLinesOptions ret = (XsPortLinesOptions)xsensdeviceapiPINVOKE.XsPortInfo_linesOptions(swigCPtr);
    return ret;
  }

  public void setLinesOptions(XsPortLinesOptions linesOptions) {
    xsensdeviceapiPINVOKE.XsPortInfo_setLinesOptions(swigCPtr, (int)linesOptions);
  }

  public void getVidPid(SWIGTYPE_p_unsigned_short vid, SWIGTYPE_p_unsigned_short pid) {
    xsensdeviceapiPINVOKE.XsPortInfo_getVidPid(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(vid), SWIGTYPE_p_unsigned_short.getCPtr(pid));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setVidPid(ushort vid, ushort pid) {
    xsensdeviceapiPINVOKE.XsPortInfo_setVidPid(swigCPtr, vid, pid);
  }

}

}
