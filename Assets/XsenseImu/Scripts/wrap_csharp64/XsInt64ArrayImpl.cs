
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

public class XsInt64ArrayImpl : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsInt64ArrayImpl(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsInt64ArrayImpl obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsInt64ArrayImpl() {
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
          xsensdeviceapiPINVOKE.delete_XsInt64ArrayImpl(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public XsInt64ArrayImpl(uint count, SWIGTYPE_p_long_long src) : this(xsensdeviceapiPINVOKE.new_XsInt64ArrayImpl__SWIG_0(count, SWIGTYPE_p_long_long.getCPtr(src)), true) {
  }

  public XsInt64ArrayImpl(uint count) : this(xsensdeviceapiPINVOKE.new_XsInt64ArrayImpl__SWIG_1(count), true) {
  }

  public XsInt64ArrayImpl() : this(xsensdeviceapiPINVOKE.new_XsInt64ArrayImpl__SWIG_2(), true) {
  }

  public XsInt64ArrayImpl(XsInt64ArrayImpl other) : this(xsensdeviceapiPINVOKE.new_XsInt64ArrayImpl__SWIG_3(XsInt64ArrayImpl.getCPtr(other)), true) {
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public XsInt64ArrayImpl(SWIGTYPE_p_long_long ref_, uint sz, XsDataFlags flags) : this(xsensdeviceapiPINVOKE.new_XsInt64ArrayImpl__SWIG_4(SWIGTYPE_p_long_long.getCPtr(ref_), sz, (int)flags), true) {
  }

  public void clear() {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_clear(swigCPtr);
  }

  public void reserve(uint count) {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_reserve(swigCPtr, count);
  }

  public uint reserved() {
    uint ret = xsensdeviceapiPINVOKE.XsInt64ArrayImpl_reserved(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_XsArrayDescriptor descriptor() {
    SWIGTYPE_p_XsArrayDescriptor ret = new SWIGTYPE_p_XsArrayDescriptor(xsensdeviceapiPINVOKE.XsInt64ArrayImpl_descriptor(swigCPtr), false);
    return ret;
  }

  public long value(uint index) {
    long ret = xsensdeviceapiPINVOKE.XsInt64ArrayImpl_value(swigCPtr, index);
    return ret;
  }

  public long first() {
    long ret = xsensdeviceapiPINVOKE.XsInt64ArrayImpl_first(swigCPtr);
    return ret;
  }

  public long last() {
    long ret = xsensdeviceapiPINVOKE.XsInt64ArrayImpl_last(swigCPtr);
    return ret;
  }

  public long at(uint index) {
    long ret = xsensdeviceapiPINVOKE.XsInt64ArrayImpl_at__SWIG_0(swigCPtr, index);
    return ret;
  }

  public void insert(long item, uint index) {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_insert__SWIG_0(swigCPtr, item, index);
  }

  public void insert(SWIGTYPE_p_long_long items, uint index, uint count) {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_insert__SWIG_1(swigCPtr, SWIGTYPE_p_long_long.getCPtr(items), index, count);
  }

  public void push_back(long item) {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_push_back(swigCPtr, item);
  }

  public void pop_back(uint count) {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_pop_back__SWIG_0(swigCPtr, count);
  }

  public void pop_back() {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_pop_back__SWIG_1(swigCPtr);
  }

  public void push_front(long item) {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_push_front(swigCPtr, item);
  }

  public void pop_front(uint count) {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_pop_front__SWIG_0(swigCPtr, count);
  }

  public void pop_front() {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_pop_front__SWIG_1(swigCPtr);
  }

  public uint size() {
    uint ret = xsensdeviceapiPINVOKE.XsInt64ArrayImpl_size(swigCPtr);
    return ret;
  }

  public void erase(uint index, uint count) {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_erase__SWIG_0(swigCPtr, index, count);
  }

  public void erase(uint index) {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_erase__SWIG_1(swigCPtr, index);
  }

  public void assign(uint count, SWIGTYPE_p_long_long src) {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_assign(swigCPtr, count, SWIGTYPE_p_long_long.getCPtr(src));
  }

  public void resize(uint count) {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_resize(swigCPtr, count);
  }

  public void setSize(uint count) {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_setSize(swigCPtr, count);
  }

  public void append(XsInt64ArrayImpl other) {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_append(swigCPtr, XsInt64ArrayImpl.getCPtr(other));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool empty() {
    bool ret = xsensdeviceapiPINVOKE.XsInt64ArrayImpl_empty(swigCPtr);
    return ret;
  }

  public void swap(XsInt64ArrayImpl other) {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_swap__SWIG_0(swigCPtr, XsInt64ArrayImpl.getCPtr(other));
    if (xsensdeviceapiPINVOKE.SWIGPendingException.Pending) throw xsensdeviceapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void swap(uint a, uint b) {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_swap__SWIG_1(swigCPtr, a, b);
  }

  public int find(long needle) {
    int ret = xsensdeviceapiPINVOKE.XsInt64ArrayImpl_find(swigCPtr, needle);
    return ret;
  }

  public void removeDuplicates() {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_removeDuplicates(swigCPtr);
  }

  public void removeDuplicatesPredicate(SWIGTYPE_p_f_p_q_const__void_p_q_const__void__int predicate) {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_removeDuplicatesPredicate(swigCPtr, SWIGTYPE_p_f_p_q_const__void_p_q_const__void__int.getCPtr(predicate));
  }

  public void sort() {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_sort(swigCPtr);
  }

  public void reverse() {
    xsensdeviceapiPINVOKE.XsInt64ArrayImpl_reverse(swigCPtr);
  }

}

}
