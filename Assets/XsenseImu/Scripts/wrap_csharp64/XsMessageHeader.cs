
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

public class XsMessageHeader : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal XsMessageHeader(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(XsMessageHeader obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~XsMessageHeader() {
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
          xsensdeviceapiPINVOKE.delete_XsMessageHeader(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public byte m_preamble {
    set {
      xsensdeviceapiPINVOKE.XsMessageHeader_m_preamble_set(swigCPtr, value);
    } 
    get {
      byte ret = xsensdeviceapiPINVOKE.XsMessageHeader_m_preamble_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_busId {
    set {
      xsensdeviceapiPINVOKE.XsMessageHeader_m_busId_set(swigCPtr, value);
    } 
    get {
      byte ret = xsensdeviceapiPINVOKE.XsMessageHeader_m_busId_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_messageId {
    set {
      xsensdeviceapiPINVOKE.XsMessageHeader_m_messageId_set(swigCPtr, value);
    } 
    get {
      byte ret = xsensdeviceapiPINVOKE.XsMessageHeader_m_messageId_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_length {
    set {
      xsensdeviceapiPINVOKE.XsMessageHeader_m_length_set(swigCPtr, value);
    } 
    get {
      byte ret = xsensdeviceapiPINVOKE.XsMessageHeader_m_length_get(swigCPtr);
      return ret;
    } 
  }

  public class LengthData : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal LengthData(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LengthData obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~LengthData() {
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
            xsensdeviceapiPINVOKE.delete_XsMessageHeader_LengthData(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
      }
    }
  
      public class ExtendedLength : global::System.IDisposable {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;
      
        internal ExtendedLength(global::System.IntPtr cPtr, bool cMemoryOwn) {
          swigCMemOwn = cMemoryOwn;
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }
      
        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ExtendedLength obj) {
          return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }
      
        ~ExtendedLength() {
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
                xsensdeviceapiPINVOKE.delete_XsMessageHeader_LengthData_ExtendedLength(swigCPtr);
              }
              swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }
          }
        }
      
            public class ExtendedParts : global::System.IDisposable {
              private global::System.Runtime.InteropServices.HandleRef swigCPtr;
              protected bool swigCMemOwn;
            
              internal ExtendedParts(global::System.IntPtr cPtr, bool cMemoryOwn) {
                swigCMemOwn = cMemoryOwn;
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
              }
            
              internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ExtendedParts obj) {
                return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
              }
            
              ~ExtendedParts() {
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
                      xsensdeviceapiPINVOKE.delete_XsMessageHeader_LengthData_ExtendedLength_ExtendedParts(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                  }
                }
              }
            
              public byte m_high {
                set {
                  xsensdeviceapiPINVOKE.XsMessageHeader_LengthData_ExtendedLength_ExtendedParts_m_high_set(swigCPtr, value);
                } 
                get {
                  byte ret = xsensdeviceapiPINVOKE.XsMessageHeader_LengthData_ExtendedLength_ExtendedParts_m_high_get(swigCPtr);
                  return ret;
                } 
              }
            
              public byte m_low {
                set {
                  xsensdeviceapiPINVOKE.XsMessageHeader_LengthData_ExtendedLength_ExtendedParts_m_low_set(swigCPtr, value);
                } 
                get {
                  byte ret = xsensdeviceapiPINVOKE.XsMessageHeader_LengthData_ExtendedLength_ExtendedParts_m_low_get(swigCPtr);
                  return ret;
                } 
              }
            
              public ExtendedParts() : this(xsensdeviceapiPINVOKE.new_XsMessageHeader_LengthData_ExtendedLength_ExtendedParts(), true) {
              }
            
            }
      
        public XsMessageHeader.LengthData.ExtendedLength.ExtendedParts m_length {
          set {
            xsensdeviceapiPINVOKE.XsMessageHeader_LengthData_ExtendedLength_m_length_set(swigCPtr, XsMessageHeader.LengthData.ExtendedLength.ExtendedParts.getCPtr(value));
          } 
          get {
            global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsMessageHeader_LengthData_ExtendedLength_m_length_get(swigCPtr);
            XsMessageHeader.LengthData.ExtendedLength.ExtendedParts ret = (cPtr == global::System.IntPtr.Zero) ? null : new XsMessageHeader.LengthData.ExtendedLength.ExtendedParts(cPtr, false);
            return ret;
          } 
        }
      
        public SWIGTYPE_p_unsigned_char m_data {
          set {
            xsensdeviceapiPINVOKE.XsMessageHeader_LengthData_ExtendedLength_m_data_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
          } 
          get {
            global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsMessageHeader_LengthData_ExtendedLength_m_data_get(swigCPtr);
            SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
            return ret;
          } 
        }
      
        public ExtendedLength() : this(xsensdeviceapiPINVOKE.new_XsMessageHeader_LengthData_ExtendedLength(), true) {
        }
      
      }
  
    public XsMessageHeader.LengthData.ExtendedLength m_extended {
      set {
        xsensdeviceapiPINVOKE.XsMessageHeader_LengthData_m_extended_set(swigCPtr, XsMessageHeader.LengthData.ExtendedLength.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsMessageHeader_LengthData_m_extended_get(swigCPtr);
        XsMessageHeader.LengthData.ExtendedLength ret = (cPtr == global::System.IntPtr.Zero) ? null : new XsMessageHeader.LengthData.ExtendedLength(cPtr, false);
        return ret;
      } 
    }
  
    public SWIGTYPE_p_unsigned_char m_data {
      set {
        xsensdeviceapiPINVOKE.XsMessageHeader_LengthData_m_data_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsMessageHeader_LengthData_m_data_get(swigCPtr);
        SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
        return ret;
      } 
    }
  
    public LengthData() : this(xsensdeviceapiPINVOKE.new_XsMessageHeader_LengthData(), true) {
    }
  
  }

  public XsMessageHeader.LengthData m_datlen {
    set {
      xsensdeviceapiPINVOKE.XsMessageHeader_m_datlen_set(swigCPtr, XsMessageHeader.LengthData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = xsensdeviceapiPINVOKE.XsMessageHeader_m_datlen_get(swigCPtr);
      XsMessageHeader.LengthData ret = (cPtr == global::System.IntPtr.Zero) ? null : new XsMessageHeader.LengthData(cPtr, false);
      return ret;
    } 
  }

  public XsMessageHeader() : this(xsensdeviceapiPINVOKE.new_XsMessageHeader(), true) {
  }

}

}
