//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace SharpFace
{

    public class Multi_SVR_patch_expert : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal Multi_SVR_patch_expert(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Multi_SVR_patch_expert obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~Multi_SVR_patch_expert()
        {
            Dispose();
        }

        public virtual void Dispose()
        {
            lock(this)
            {
                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        LandmarkDetectorPINVOKE.delete_Multi_SVR_patch_expert(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public int width
        {
            set
            {
                LandmarkDetectorPINVOKE.Multi_SVR_patch_expert_width_set(swigCPtr, value);
            }
            get
            {
                int ret = LandmarkDetectorPINVOKE.Multi_SVR_patch_expert_width_get(swigCPtr);
                return ret;
            }
        }

        public int height
        {
            set
            {
                LandmarkDetectorPINVOKE.Multi_SVR_patch_expert_height_set(swigCPtr, value);
            }
            get
            {
                int ret = LandmarkDetectorPINVOKE.Multi_SVR_patch_expert_height_get(swigCPtr);
                return ret;
            }
        }

        public SWIGTYPE_p_std__vectorT_LandmarkDetector__SVR_patch_expert_t svr_patch_experts
        {
            set
            {
                LandmarkDetectorPINVOKE.Multi_SVR_patch_expert_svr_patch_experts_set(swigCPtr, value.Pointer);
            }
            get
            {
                global::System.IntPtr cPtr = LandmarkDetectorPINVOKE.Multi_SVR_patch_expert_svr_patch_experts_get(swigCPtr);
                SWIGTYPE_p_std__vectorT_LandmarkDetector__SVR_patch_expert_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_LandmarkDetector__SVR_patch_expert_t(cPtr, false);
                return ret;
            }
        }

        public Multi_SVR_patch_expert() : this(LandmarkDetectorPINVOKE.new_Multi_SVR_patch_expert__SWIG_0(), true)
        {
        }

        public Multi_SVR_patch_expert(Multi_SVR_patch_expert other) : this(LandmarkDetectorPINVOKE.new_Multi_SVR_patch_expert__SWIG_1(other.Pointer), true)
        {
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void Read(SWIGTYPE_p_std__ifstream stream)
        {
            LandmarkDetectorPINVOKE.Multi_SVR_patch_expert_Read(swigCPtr, stream.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void Response(SWIGTYPE_p_cv__Mat_T_float_t area_of_interest, SWIGTYPE_p_cv__Mat_T_float_t response)
        {
            LandmarkDetectorPINVOKE.Multi_SVR_patch_expert_Response(swigCPtr, area_of_interest.Pointer, response.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void ResponseDepth(SWIGTYPE_p_cv__Mat_T_float_t area_of_interest, SWIGTYPE_p_cv__Mat_T_float_t response)
        {
            LandmarkDetectorPINVOKE.Multi_SVR_patch_expert_ResponseDepth(swigCPtr, area_of_interest.Pointer, response.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

    }

}
