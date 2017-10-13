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

    public class PDM : global::System.IDisposable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal PDM(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PDM obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~PDM()
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
                        LandmarkDetectorPINVOKE.delete_PDM(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public SWIGTYPE_p_cv__Mat_T_double_t mean_shape
        {
            set
            {
                LandmarkDetectorPINVOKE.PDM_mean_shape_set(swigCPtr, value.Pointer);
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                SWIGTYPE_p_cv__Mat_T_double_t ret = new SWIGTYPE_p_cv__Mat_T_double_t(LandmarkDetectorPINVOKE.PDM_mean_shape_get(swigCPtr), true);
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        public SWIGTYPE_p_cv__Mat_T_double_t princ_comp
        {
            set
            {
                LandmarkDetectorPINVOKE.PDM_princ_comp_set(swigCPtr, value.Pointer);
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                SWIGTYPE_p_cv__Mat_T_double_t ret = new SWIGTYPE_p_cv__Mat_T_double_t(LandmarkDetectorPINVOKE.PDM_princ_comp_get(swigCPtr), true);
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        public SWIGTYPE_p_cv__Mat_T_double_t eigen_values
        {
            set
            {
                LandmarkDetectorPINVOKE.PDM_eigen_values_set(swigCPtr, value.Pointer);
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            }
            get
            {
                SWIGTYPE_p_cv__Mat_T_double_t ret = new SWIGTYPE_p_cv__Mat_T_double_t(LandmarkDetectorPINVOKE.PDM_eigen_values_get(swigCPtr), true);
                if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
                return ret;
            }
        }

        public PDM() : this(LandmarkDetectorPINVOKE.new_PDM__SWIG_0(), true)
        {
        }

        public PDM(PDM other) : this(LandmarkDetectorPINVOKE.new_PDM__SWIG_1(other.Pointer), true)
        {
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void Read(string location)
        {
            LandmarkDetectorPINVOKE.PDM_Read(swigCPtr, location);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public int NumberOfPoints()
        {
            int ret = LandmarkDetectorPINVOKE.PDM_NumberOfPoints(swigCPtr);
            return ret;
        }

        public int NumberOfModes()
        {
            int ret = LandmarkDetectorPINVOKE.PDM_NumberOfModes(swigCPtr);
            return ret;
        }

        public void Clamp(SWIGTYPE_p_cv__Mat_T_float_t params_local, SWIGTYPE_p_cv__Vec6d params_global, FaceModelParameters arg2)
        {
            LandmarkDetectorPINVOKE.PDM_Clamp(swigCPtr, params_local.Pointer, params_global.Pointer, arg2.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void CalcShape3D(SWIGTYPE_p_cv__Mat_T_double_t out_shape, SWIGTYPE_p_cv__Mat_T_double_t params_local)
        {
            LandmarkDetectorPINVOKE.PDM_CalcShape3D(swigCPtr, out_shape.Pointer, params_local.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void CalcShape2D(SWIGTYPE_p_cv__Mat_T_double_t out_shape, SWIGTYPE_p_cv__Mat_T_double_t params_local, SWIGTYPE_p_cv__Vec6d params_global)
        {
            LandmarkDetectorPINVOKE.PDM_CalcShape2D(swigCPtr, out_shape.Pointer, params_local.Pointer, params_global.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void CalcParams(SWIGTYPE_p_cv__Vec6d out_params_global, SWIGTYPE_p_cv__Rect_T_double_t bounding_box, SWIGTYPE_p_cv__Mat_T_double_t params_local, SWIGTYPE_p_cv__Vec3d rotation)
        {
            LandmarkDetectorPINVOKE.PDM_CalcParams__SWIG_0(swigCPtr, out_params_global.Pointer, bounding_box.Pointer, params_local.Pointer, rotation.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void CalcParams(SWIGTYPE_p_cv__Vec6d out_params_global, SWIGTYPE_p_cv__Rect_T_double_t bounding_box, SWIGTYPE_p_cv__Mat_T_double_t params_local)
        {
            LandmarkDetectorPINVOKE.PDM_CalcParams__SWIG_1(swigCPtr, out_params_global.Pointer, bounding_box.Pointer, params_local.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void CalcParams(SWIGTYPE_p_cv__Vec6d out_params_global, SWIGTYPE_p_cv__Mat_T_double_t out_params_local, SWIGTYPE_p_cv__Mat_T_double_t landmark_locations, SWIGTYPE_p_cv__Vec3d rotation)
        {
            LandmarkDetectorPINVOKE.PDM_CalcParams__SWIG_2(swigCPtr, out_params_global.Pointer, out_params_local.Pointer, landmark_locations.Pointer, rotation.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void CalcParams(SWIGTYPE_p_cv__Vec6d out_params_global, SWIGTYPE_p_cv__Mat_T_double_t out_params_local, SWIGTYPE_p_cv__Mat_T_double_t landmark_locations)
        {
            LandmarkDetectorPINVOKE.PDM_CalcParams__SWIG_3(swigCPtr, out_params_global.Pointer, out_params_local.Pointer, landmark_locations.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void CalcBoundingBox(SWIGTYPE_p_cv__Rect out_bounding_box, SWIGTYPE_p_cv__Vec6d params_global, SWIGTYPE_p_cv__Mat_T_double_t params_local)
        {
            LandmarkDetectorPINVOKE.PDM_CalcBoundingBox(swigCPtr, out_bounding_box.Pointer, params_global.Pointer, params_local.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void ComputeRigidJacobian(SWIGTYPE_p_cv__Mat_T_float_t params_local, SWIGTYPE_p_cv__Vec6d params_global, SWIGTYPE_p_cv__Mat_T_float_t Jacob, SWIGTYPE_p_cv__Mat_T_float_t W, SWIGTYPE_p_cv__Mat_T_float_t Jacob_t_w)
        {
            LandmarkDetectorPINVOKE.PDM_ComputeRigidJacobian(swigCPtr, params_local.Pointer, params_global.Pointer, Jacob.Pointer, W.Pointer, Jacob_t_w.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void ComputeJacobian(SWIGTYPE_p_cv__Mat_T_float_t params_local, SWIGTYPE_p_cv__Vec6d params_global, SWIGTYPE_p_cv__Mat_T_float_t Jacobian, SWIGTYPE_p_cv__Mat_T_float_t W, SWIGTYPE_p_cv__Mat_T_float_t Jacob_t_w)
        {
            LandmarkDetectorPINVOKE.PDM_ComputeJacobian(swigCPtr, params_local.Pointer, params_global.Pointer, Jacobian.Pointer, W.Pointer, Jacob_t_w.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void UpdateModelParameters(SWIGTYPE_p_cv__Mat_T_float_t delta_p, SWIGTYPE_p_cv__Mat_T_float_t params_local, SWIGTYPE_p_cv__Vec6d params_global)
        {
            LandmarkDetectorPINVOKE.PDM_UpdateModelParameters(swigCPtr, delta_p.Pointer, params_local.Pointer, params_global.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

    }

}
