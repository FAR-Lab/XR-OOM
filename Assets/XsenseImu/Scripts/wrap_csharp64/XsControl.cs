
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

public class XsControl : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsControl(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsControl obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsControl() {
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
          xsensdeviceapiPINVOKE.delete_XsControl(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public static XsControl construct() {
    global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsControl_construct();
    XsControl ret = (cPtr == global::System.IntPtr.Zero) ? null : new XsControl(cPtr, false);
    return ret;
  }

  public void destruct() {
    xsensdeviceapiPINVOKE.XsControl_destruct(swigCPtr);
  }

  public void flushInputBuffers() {
    xsensdeviceapiPINVOKE.XsControl_flushInputBuffers(swigCPtr);
  }

  public static XsString resultText(XsResultValue resultCode) {
    XsString ret = new XsString(xsensdeviceapiPINVOKE.XsControl_resultText((int)resultCode), true);
    return ret;
  }

  public void clearHardwareError() {
    xsensdeviceapiPINVOKE.XsControl_clearHardwareError(swigCPtr);
  }

  public void close() {
    xsensdeviceapiPINVOKE.XsControl_close(swigCPtr);
  }

  public bool openPort(XsString portname, XsBaudRate baudrate, uint timeout, bool detectRs485) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_openPort__SWIG_0(swigCPtr, XsString.getCPtr(portname), (int)baudrate, timeout, detectRs485);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool openPort(XsString portname, XsBaudRate baudrate, uint timeout) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_openPort__SWIG_1(swigCPtr, XsString.getCPtr(portname), (int)baudrate, timeout);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool openPort(XsString portname, XsBaudRate baudrate) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_openPort__SWIG_2(swigCPtr, XsString.getCPtr(portname), (int)baudrate);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool openPort(XsPortInfo portinfo, uint timeout, bool detectRs485) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_openPort__SWIG_3(swigCPtr, XsPortInfo.getCPtr(portinfo), timeout, detectRs485);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool openPort(XsPortInfo portinfo, uint timeout) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_openPort__SWIG_4(swigCPtr, XsPortInfo.getCPtr(portinfo), timeout);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool openPort(XsPortInfo portinfo) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_openPort__SWIG_5(swigCPtr, XsPortInfo.getCPtr(portinfo));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool openPortWithCredentials(XsPortInfo portinfo, XsString id, XsString key, uint timeout) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_openPortWithCredentials__SWIG_0(swigCPtr, XsPortInfo.getCPtr(portinfo), XsString.getCPtr(id), XsString.getCPtr(key), timeout);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool openPortWithCredentials(XsPortInfo portinfo, XsString id, XsString key) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_openPortWithCredentials__SWIG_1(swigCPtr, XsPortInfo.getCPtr(portinfo), XsString.getCPtr(id), XsString.getCPtr(key));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool openCustomPort(int channelId, uint channelLatency, bool detectRs485) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_openCustomPort__SWIG_0(swigCPtr, channelId, channelLatency, detectRs485);
    return ret;
  }

  public bool openCustomPort(int channelId, uint channelLatency) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_openCustomPort__SWIG_1(swigCPtr, channelId, channelLatency);
    return ret;
  }

  public bool openImarPort_internal(XsString portname, XsBaudRate baudrate, int imarType, uint timeout) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_openImarPort_internal__SWIG_0(swigCPtr, XsString.getCPtr(portname), (int)baudrate, imarType, timeout);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool openImarPort_internal(XsString portname, XsBaudRate baudrate, int imarType) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_openImarPort_internal__SWIG_1(swigCPtr, XsString.getCPtr(portname), (int)baudrate, imarType);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool openPort(int portNr, XsBaudRate baudrate, uint timeout, bool detectRs485) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_openPort__SWIG_6(swigCPtr, portNr, (int)baudrate, timeout, detectRs485);
    return ret;
  }

  public bool openPort(int portNr, XsBaudRate baudrate, uint timeout) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_openPort__SWIG_7(swigCPtr, portNr, (int)baudrate, timeout);
    return ret;
  }

  public bool openPort(int portNr, XsBaudRate baudrate) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_openPort__SWIG_8(swigCPtr, portNr, (int)baudrate);
    return ret;
  }

  public void closePort(XsString portname) {
    xsensdeviceapiPINVOKE.XsControl_closePort__SWIG_0(swigCPtr, XsString.getCPtr(portname));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void closePort(XsDeviceId deviceId) {
    xsensdeviceapiPINVOKE.XsControl_closePort__SWIG_1(swigCPtr, XsDeviceId.getCPtr(deviceId));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void closePort(XsPortInfo portinfo) {
    xsensdeviceapiPINVOKE.XsControl_closePort__SWIG_2(swigCPtr, XsPortInfo.getCPtr(portinfo));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void closeCustomPort(int channelId) {
    xsensdeviceapiPINVOKE.XsControl_closeCustomPort(swigCPtr, channelId);
  }

  public void closePort(int portNr) {
    xsensdeviceapiPINVOKE.XsControl_closePort__SWIG_3(swigCPtr, portNr);
  }

  public void closePort(XsDevice device) {
    xsensdeviceapiPINVOKE.XsControl_closePort__SWIG_4(swigCPtr, XsDevice.getCPtr(device));
  }

  public XsPortInfo customPortInfo(int channelId) {
    XsPortInfo ret = new XsPortInfo(xsensdeviceapiPINVOKE.XsControl_customPortInfo(swigCPtr, channelId), true);
    return ret;
  }

  public bool openLogFile(XsString filename) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_openLogFile(swigCPtr, XsString.getCPtr(filename));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public XsResultValue lastResult() {
    XsResultValue ret = (XsResultValue)xsensdeviceapiPINVOKE.XsControl_lastResult(swigCPtr);
    return ret;
  }

  public XsString lastResultText() {
    XsString ret = new XsString(xsensdeviceapiPINVOKE.XsControl_lastResultText(swigCPtr), true);
    return ret;
  }

  public XsResultValue lastHardwareError() {
    XsResultValue ret = (XsResultValue)xsensdeviceapiPINVOKE.XsControl_lastHardwareError(swigCPtr);
    return ret;
  }

  public XsDeviceId lastHardwareErrorDeviceId() {
    XsDeviceId ret = new XsDeviceId(xsensdeviceapiPINVOKE.XsControl_lastHardwareErrorDeviceId(swigCPtr), true);
    return ret;
  }

  public int deviceCount() {
    int ret = xsensdeviceapiPINVOKE.XsControl_deviceCount(swigCPtr);
    return ret;
  }

  public int mainDeviceCount() {
    int ret = xsensdeviceapiPINVOKE.XsControl_mainDeviceCount(swigCPtr);
    return ret;
  }

  public XsDeviceIdArray mainDeviceIds() {
    XsDeviceIdArray ret = new XsDeviceIdArray(xsensdeviceapiPINVOKE.XsControl_mainDeviceIds(swigCPtr), true);
    return ret;
  }

  public int mtCount() {
    int ret = xsensdeviceapiPINVOKE.XsControl_mtCount(swigCPtr);
    return ret;
  }

  public XsDeviceIdArray mtDeviceIds() {
    XsDeviceIdArray ret = new XsDeviceIdArray(xsensdeviceapiPINVOKE.XsControl_mtDeviceIds(swigCPtr), true);
    return ret;
  }

  public XsDeviceIdArray deviceIds() {
    XsDeviceIdArray ret = new XsDeviceIdArray(xsensdeviceapiPINVOKE.XsControl_deviceIds(swigCPtr), true);
    return ret;
  }

  public XsDevice getDeviceFromLocationId(ushort locationId) {
    global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsControl_getDeviceFromLocationId(swigCPtr, locationId);
    XsDevice ret = (cPtr == global::System.IntPtr.Zero) ? null : new XsDevice(cPtr, false);
    return ret;
  }

  public XsDeviceId dockDeviceId(XsDeviceId deviceId) {
    XsDeviceId ret = new XsDeviceId(xsensdeviceapiPINVOKE.XsControl_dockDeviceId(swigCPtr, XsDeviceId.getCPtr(deviceId)), true);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isDeviceWireless(XsDeviceId deviceId) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_isDeviceWireless(swigCPtr, XsDeviceId.getCPtr(deviceId));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isDeviceDocked(XsDeviceId deviceId) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_isDeviceDocked(swigCPtr, XsDeviceId.getCPtr(deviceId));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool loadFilterProfiles(XsString filename) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_loadFilterProfiles(swigCPtr, XsString.getCPtr(filename));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public XsOption enabledOptions() {
    XsOption ret = (XsOption)xsensdeviceapiPINVOKE.XsControl_enabledOptions(swigCPtr);
    return ret;
  }

  public XsOption disabledOptions() {
    XsOption ret = (XsOption)xsensdeviceapiPINVOKE.XsControl_disabledOptions(swigCPtr);
    return ret;
  }

  public void setOptions(XsOption enable, XsOption disable) {
    xsensdeviceapiPINVOKE.XsControl_setOptions(swigCPtr, (int)enable, (int)disable);
  }

  public void setOptionsForce(XsOption enabled) {
    xsensdeviceapiPINVOKE.XsControl_setOptionsForce(swigCPtr, (int)enabled);
  }

  public bool setInitialPositionLLA(XsVector lla) {
    bool ret = xsensdeviceapiPINVOKE.XsControl_setInitialPositionLLA(swigCPtr, XsVector.getCPtr(lla));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public XsDevice device(XsDeviceId deviceId) {
    global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsControl_device(swigCPtr, XsDeviceId.getCPtr(deviceId));
    XsDevice ret = (cPtr == global::System.IntPtr.Zero) ? null : new XsDevice(cPtr, false);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public XsDevicePtrArray mainDevices() {
    XsDevicePtrArray ret = new XsDevicePtrArray(xsensdeviceapiPINVOKE.XsControl_mainDevices(swigCPtr), true);
    return ret;
  }

  public XsDevice broadcast() {
    global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsControl_broadcast(swigCPtr);
    XsDevice ret = (cPtr == global::System.IntPtr.Zero) ? null : new XsDevice(cPtr, false);
    return ret;
  }

  public void transmissionReceived(int channelId, XsByteArray data) {
    xsensdeviceapiPINVOKE.XsControl_transmissionReceived(swigCPtr, channelId, XsByteArray.getCPtr(data));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void clearCallbackHandlers(bool chain) {
    xsensdeviceapiPINVOKE.XsControl_clearCallbackHandlers__SWIG_0(swigCPtr, chain);
  }

  public void clearCallbackHandlers() {
    xsensdeviceapiPINVOKE.XsControl_clearCallbackHandlers__SWIG_1(swigCPtr);
  }

  public void addCallbackHandler(XsCallbackPlainC cb, bool chain) {
    xsensdeviceapiPINVOKE.XsControl_addCallbackHandler__SWIG_0(swigCPtr, XsCallbackPlainC.getCPtr(cb), chain);
  }

  public void addCallbackHandler(XsCallbackPlainC cb) {
    xsensdeviceapiPINVOKE.XsControl_addCallbackHandler__SWIG_1(swigCPtr, XsCallbackPlainC.getCPtr(cb));
  }

  public void removeCallbackHandler(XsCallbackPlainC cb, bool chain) {
    xsensdeviceapiPINVOKE.XsControl_removeCallbackHandler__SWIG_0(swigCPtr, XsCallbackPlainC.getCPtr(cb), chain);
  }

  public void removeCallbackHandler(XsCallbackPlainC cb) {
    xsensdeviceapiPINVOKE.XsControl_removeCallbackHandler__SWIG_1(swigCPtr, XsCallbackPlainC.getCPtr(cb));
  }

  public void gotoConfig() {
    xsensdeviceapiPINVOKE.XsControl_gotoConfig(swigCPtr);
  }

  public void gotoMeasurement() {
    xsensdeviceapiPINVOKE.XsControl_gotoMeasurement(swigCPtr);
  }

  public XsResultValue startRestoreCommunication(XsString portName) {
    XsResultValue ret = (XsResultValue)xsensdeviceapiPINVOKE.XsControl_startRestoreCommunication(swigCPtr, XsString.getCPtr(portName));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void stopRestoreCommunication() {
    xsensdeviceapiPINVOKE.XsControl_stopRestoreCommunication(swigCPtr);
  }

  public XsControl() : this(xsensdeviceapiPINVOKE.new_XsControl(), true) {
  }

}

}
