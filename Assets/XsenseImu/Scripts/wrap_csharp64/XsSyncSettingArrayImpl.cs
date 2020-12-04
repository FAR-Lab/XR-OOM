
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

public class XsSyncSettingArrayImpl : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsSyncSettingArrayImpl(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsSyncSettingArrayImpl obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsSyncSettingArrayImpl() {
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
          xsensdeviceapiPINVOKE.delete_XsSyncSettingArrayImpl(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public XsSyncSettingArrayImpl(uint count, XsSyncSetting src) : this(xsensdeviceapiPINVOKE.new_XsSyncSettingArrayImpl__SWIG_0(count, XsSyncSetting.getCPtr(src)), true) {
  }

  public XsSyncSettingArrayImpl(uint count) : this(xsensdeviceapiPINVOKE.new_XsSyncSettingArrayImpl__SWIG_1(count), true) {
  }

  public XsSyncSettingArrayImpl() : this(xsensdeviceapiPINVOKE.new_XsSyncSettingArrayImpl__SWIG_2(), true) {
  }

  public XsSyncSettingArrayImpl(XsSyncSettingArrayImpl other) : this(xsensdeviceapiPINVOKE.new_XsSyncSettingArrayImpl__SWIG_3(XsSyncSettingArrayImpl.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsSyncSettingArrayImpl(XsSyncSetting ref_, uint sz, XsDataFlags flags) : this(xsensdeviceapiPINVOKE.new_XsSyncSettingArrayImpl__SWIG_4(XsSyncSetting.getCPtr(ref_), sz, (int)flags), true) {
  }

  public void clear() {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_clear(swigCPtr);
  }

  public void reserve(uint count) {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_reserve(swigCPtr, count);
  }

  public uint reserved() {
    uint ret = xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_reserved(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_XsArrayDescriptor descriptor() {
    SWIGTYPE_p_XsArrayDescriptor ret = new SWIGTYPE_p_XsArrayDescriptor(xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_descriptor(swigCPtr), false);
    return ret;
  }

  public XsSyncSetting value(uint index) {
    XsSyncSetting ret = new XsSyncSetting(xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_value(swigCPtr, index), true);
    return ret;
  }

  public XsSyncSetting first() {
    XsSyncSetting ret = new XsSyncSetting(xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_first(swigCPtr), true);
    return ret;
  }

  public XsSyncSetting last() {
    XsSyncSetting ret = new XsSyncSetting(xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_last(swigCPtr), true);
    return ret;
  }

  public XsSyncSetting at(uint index) {
    XsSyncSetting ret = new XsSyncSetting(xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_at__SWIG_0(swigCPtr, index), false);
    return ret;
  }

  public void insert(XsSyncSetting item, uint index) {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_insert__SWIG_0(swigCPtr, XsSyncSetting.getCPtr(item), index);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void insert(XsSyncSetting items, uint index, uint count) {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_insert__SWIG_1(swigCPtr, XsSyncSetting.getCPtr(items), index, count);
  }

  public void push_back(XsSyncSetting item) {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_push_back(swigCPtr, XsSyncSetting.getCPtr(item));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void pop_back(uint count) {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_pop_back__SWIG_0(swigCPtr, count);
  }

  public void pop_back() {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_pop_back__SWIG_1(swigCPtr);
  }

  public void push_front(XsSyncSetting item) {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_push_front(swigCPtr, XsSyncSetting.getCPtr(item));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void pop_front(uint count) {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_pop_front__SWIG_0(swigCPtr, count);
  }

  public void pop_front() {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_pop_front__SWIG_1(swigCPtr);
  }

  public uint size() {
    uint ret = xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_size(swigCPtr);
    return ret;
  }

  public void erase(uint index, uint count) {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_erase__SWIG_0(swigCPtr, index, count);
  }

  public void erase(uint index) {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_erase__SWIG_1(swigCPtr, index);
  }

  public void assign(uint count, XsSyncSetting src) {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_assign(swigCPtr, count, XsSyncSetting.getCPtr(src));
  }

  public void resize(uint count) {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_resize(swigCPtr, count);
  }

  public void setSize(uint count) {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_setSize(swigCPtr, count);
  }

  public void append(XsSyncSettingArrayImpl other) {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_append(swigCPtr, XsSyncSettingArrayImpl.getCPtr(other));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool empty() {
    bool ret = xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_empty(swigCPtr);
    return ret;
  }

  public void swap(XsSyncSettingArrayImpl other) {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_swap__SWIG_0(swigCPtr, XsSyncSettingArrayImpl.getCPtr(other));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void swap(uint a, uint b) {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_swap__SWIG_1(swigCPtr, a, b);
  }

  public int find(XsSyncSetting needle) {
    int ret = xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_find(swigCPtr, XsSyncSetting.getCPtr(needle));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void removeDuplicates() {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_removeDuplicates(swigCPtr);
  }

  public void removeDuplicatesPredicate(SWIGTYPE_p_f_p_q_const__void_p_q_const__void__int predicate) {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_removeDuplicatesPredicate(swigCPtr, SWIGTYPE_p_f_p_q_const__void_p_q_const__void__int.getCPtr(predicate));
  }

  public void sort() {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_sort(swigCPtr);
  }

  public void reverse() {
    xsensdeviceapiPINVOKE.XsSyncSettingArrayImpl_reverse(swigCPtr);
  }

}

}
