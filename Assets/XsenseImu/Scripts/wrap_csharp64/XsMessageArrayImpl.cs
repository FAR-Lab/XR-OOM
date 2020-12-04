
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

public class XsMessageArrayImpl : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsMessageArrayImpl(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsMessageArrayImpl obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsMessageArrayImpl() {
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
          xsensdeviceapiPINVOKE.delete_XsMessageArrayImpl(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public XsMessageArrayImpl(uint count, XsMessage src) : this(xsensdeviceapiPINVOKE.new_XsMessageArrayImpl__SWIG_0(count, XsMessage.getCPtr(src)), true) {
  }

  public XsMessageArrayImpl(uint count) : this(xsensdeviceapiPINVOKE.new_XsMessageArrayImpl__SWIG_1(count), true) {
  }

  public XsMessageArrayImpl() : this(xsensdeviceapiPINVOKE.new_XsMessageArrayImpl__SWIG_2(), true) {
  }

  public XsMessageArrayImpl(XsMessageArrayImpl other) : this(xsensdeviceapiPINVOKE.new_XsMessageArrayImpl__SWIG_3(XsMessageArrayImpl.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsMessageArrayImpl(XsMessage ref_, uint sz, XsDataFlags flags) : this(xsensdeviceapiPINVOKE.new_XsMessageArrayImpl__SWIG_4(XsMessage.getCPtr(ref_), sz, (int)flags), true) {
  }

  public void clear() {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_clear(swigCPtr);
  }

  public void reserve(uint count) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_reserve(swigCPtr, count);
  }

  public uint reserved() {
    uint ret = xsensdeviceapiPINVOKE.XsMessageArrayImpl_reserved(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_XsArrayDescriptor descriptor() {
    SWIGTYPE_p_XsArrayDescriptor ret = new SWIGTYPE_p_XsArrayDescriptor(xsensdeviceapiPINVOKE.XsMessageArrayImpl_descriptor(swigCPtr), false);
    return ret;
  }

  public XsMessage value(uint index) {
    XsMessage ret = new XsMessage(xsensdeviceapiPINVOKE.XsMessageArrayImpl_value(swigCPtr, index), true);
    return ret;
  }

  public XsMessage first() {
    XsMessage ret = new XsMessage(xsensdeviceapiPINVOKE.XsMessageArrayImpl_first(swigCPtr), true);
    return ret;
  }

  public XsMessage last() {
    XsMessage ret = new XsMessage(xsensdeviceapiPINVOKE.XsMessageArrayImpl_last(swigCPtr), true);
    return ret;
  }

  public XsMessage at(uint index) {
    XsMessage ret = new XsMessage(xsensdeviceapiPINVOKE.XsMessageArrayImpl_at__SWIG_0(swigCPtr, index), false);
    return ret;
  }

  public void insert(XsMessage item, uint index) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_insert__SWIG_0(swigCPtr, XsMessage.getCPtr(item), index);
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void insert(XsMessage items, uint index, uint count) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_insert__SWIG_1(swigCPtr, XsMessage.getCPtr(items), index, count);
  }

  public void push_back(XsMessage item) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_push_back(swigCPtr, XsMessage.getCPtr(item));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void pop_back(uint count) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_pop_back__SWIG_0(swigCPtr, count);
  }

  public void pop_back() {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_pop_back__SWIG_1(swigCPtr);
  }

  public void push_front(XsMessage item) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_push_front(swigCPtr, XsMessage.getCPtr(item));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void pop_front(uint count) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_pop_front__SWIG_0(swigCPtr, count);
  }

  public void pop_front() {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_pop_front__SWIG_1(swigCPtr);
  }

  public uint size() {
    uint ret = xsensdeviceapiPINVOKE.XsMessageArrayImpl_size(swigCPtr);
    return ret;
  }

  public void erase(uint index, uint count) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_erase__SWIG_0(swigCPtr, index, count);
  }

  public void erase(uint index) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_erase__SWIG_1(swigCPtr, index);
  }

  public void assign(uint count, XsMessage src) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_assign(swigCPtr, count, XsMessage.getCPtr(src));
  }

  public void resize(uint count) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_resize(swigCPtr, count);
  }

  public void setSize(uint count) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_setSize(swigCPtr, count);
  }

  public void append(XsMessageArrayImpl other) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_append(swigCPtr, XsMessageArrayImpl.getCPtr(other));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool empty() {
    bool ret = xsensdeviceapiPINVOKE.XsMessageArrayImpl_empty(swigCPtr);
    return ret;
  }

  public void swap(XsMessageArrayImpl other) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_swap__SWIG_0(swigCPtr, XsMessageArrayImpl.getCPtr(other));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void swap(uint a, uint b) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_swap__SWIG_1(swigCPtr, a, b);
  }

  public int find(XsMessage needle) {
    int ret = xsensdeviceapiPINVOKE.XsMessageArrayImpl_find(swigCPtr, XsMessage.getCPtr(needle));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void removeDuplicates() {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_removeDuplicates(swigCPtr);
  }

  public void removeDuplicatesPredicate(SWIGTYPE_p_f_p_q_const__void_p_q_const__void__int predicate) {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_removeDuplicatesPredicate(swigCPtr, SWIGTYPE_p_f_p_q_const__void_p_q_const__void__int.getCPtr(predicate));
  }

  public void sort() {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_sort(swigCPtr);
  }

  public void reverse() {
    xsensdeviceapiPINVOKE.XsMessageArrayImpl_reverse(swigCPtr);
  }

}

}
