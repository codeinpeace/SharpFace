//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CVPoint_Pair : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CVPoint_Pair(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CVPoint_Pair obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CVPoint_Pair() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LaandmrkDetectorPINVOKE.delete_CVPoint_Pair(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public CVPoint_Pair() : this(LaandmrkDetectorPINVOKE.new_CVPoint_Pair__SWIG_0(), true) {
  }

  public CVPoint_Pair(SWIGTYPE_p_cv__Point t, SWIGTYPE_p_cv__Point u) : this(LaandmrkDetectorPINVOKE.new_CVPoint_Pair__SWIG_1(SWIGTYPE_p_cv__Point.getCPtr(t), SWIGTYPE_p_cv__Point.getCPtr(u)), true) {
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public CVPoint_Pair(CVPoint_Pair p) : this(LaandmrkDetectorPINVOKE.new_CVPoint_Pair__SWIG_2(CVPoint_Pair.getCPtr(p)), true) {
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_cv__Point first {
    set {
      LaandmrkDetectorPINVOKE.CVPoint_Pair_first_set(swigCPtr, SWIGTYPE_p_cv__Point.getCPtr(value));
      if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_cv__Point ret = new SWIGTYPE_p_cv__Point(LaandmrkDetectorPINVOKE.CVPoint_Pair_first_get(swigCPtr), true);
      if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_cv__Point second {
    set {
      LaandmrkDetectorPINVOKE.CVPoint_Pair_second_set(swigCPtr, SWIGTYPE_p_cv__Point.getCPtr(value));
      if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_cv__Point ret = new SWIGTYPE_p_cv__Point(LaandmrkDetectorPINVOKE.CVPoint_Pair_second_get(swigCPtr), true);
      if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}