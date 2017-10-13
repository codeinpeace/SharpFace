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

    public class IntList2N : global::System.IDisposable, global::System.Collections.IEnumerable
        , global::System.Collections.Generic.IEnumerable<IntList>
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;
        protected bool swigCMemOwn;

        internal IntList2N(global::System.IntPtr cPtr, bool cMemoryOwn)
        {
            swigCMemOwn = cMemoryOwn;
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(IntList2N obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        ~IntList2N()
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
                        LandmarkDetectorPINVOKE.delete_IntList2N(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }
                global::System.GC.SuppressFinalize(this);
            }
        }

        public IntList2N(global::System.Collections.ICollection c) : this()
        {
            if (c == null)
                throw new global::System.ArgumentNullException("c");
            foreach (IntList element in c)
            {
                this.Add(element);
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return false;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public IntList this[int index]
        {
            get
            {
                return getitem(index);
            }
            set
            {
                setitem(index, value);
            }
        }

        public int Capacity
        {
            get
            {
                return (int)capacity();
            }
            set
            {
                if (value < size())
                    throw new global::System.ArgumentOutOfRangeException("Capacity");
                reserve((uint)value);
            }
        }

        public int Count
        {
            get
            {
                return (int)size();
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }

        public void CopyTo(IntList[] array)
        {
            CopyTo(0, array, 0, this.Count);
        }

        public void CopyTo(IntList[] array, int arrayIndex)
        {
            CopyTo(0, array, arrayIndex, this.Count);
        }

        public void CopyTo(int index, IntList[] array, int arrayIndex, int count)
        {
            if (array == null)
                throw new global::System.ArgumentNullException("array");
            if (index < 0)
                throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
            if (arrayIndex < 0)
                throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
            if (count < 0)
                throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
            if (array.Rank > 1)
                throw new global::System.ArgumentException("Multi dimensional array.", "array");
            if (index+count > this.Count || arrayIndex+count > array.Length)
                throw new global::System.ArgumentException("Number of elements to copy is too large.");
            for (int i=0; i<count; i++)
                array.SetValue(getitemcopy(index+i), arrayIndex+i);
        }

        global::System.Collections.Generic.IEnumerator<IntList> global::System.Collections.Generic.IEnumerable<IntList>.GetEnumerator()
        {
            return new IntList2NEnumerator(this);
        }

        global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
        {
            return new IntList2NEnumerator(this);
        }

        public IntList2NEnumerator GetEnumerator()
        {
            return new IntList2NEnumerator(this);
        }

        // Type-safe enumerator
        /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
        /// whenever the collection is modified. This has been done for changes in the size of the
        /// collection but not when one of the elements of the collection is modified as it is a bit
        /// tricky to detect unmanaged code that modifies the collection under our feet.
        public sealed class IntList2NEnumerator : global::System.Collections.IEnumerator
            , global::System.Collections.Generic.IEnumerator<IntList>
        {
            private IntList2N collectionRef;
            private int currentIndex;
            private object currentObject;
            private int currentSize;

            public IntList2NEnumerator(IntList2N collection)
            {
                collectionRef = collection;
                currentIndex = -1;
                currentObject = null;
                currentSize = collectionRef.Count;
            }

            // Type-safe iterator Current
            public IntList Current
            {
                get
                {
                    if (currentIndex == -1)
                        throw new global::System.InvalidOperationException("Enumeration not started.");
                    if (currentIndex > currentSize - 1)
                        throw new global::System.InvalidOperationException("Enumeration finished.");
                    if (currentObject == null)
                        throw new global::System.InvalidOperationException("Collection modified.");
                    return (IntList)currentObject;
                }
            }

            // Type-unsafe IEnumerator.Current
            object global::System.Collections.IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }

            public bool MoveNext()
            {
                int size = collectionRef.Count;
                bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
                if (moveOkay)
                {
                    currentIndex++;
                    currentObject = collectionRef[currentIndex];
                }
                else
                {
                    currentObject = null;
                }
                return moveOkay;
            }

            public void Reset()
            {
                currentIndex = -1;
                currentObject = null;
                if (collectionRef.Count != currentSize)
                {
                    throw new global::System.InvalidOperationException("Collection modified.");
                }
            }

            public void Dispose()
            {
                currentIndex = -1;
                currentObject = null;
            }
        }

        public void Clear()
        {
            LandmarkDetectorPINVOKE.IntList2N_Clear(swigCPtr);
        }

        public void Add(IntList x)
        {
            LandmarkDetectorPINVOKE.IntList2N_Add(swigCPtr, x.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        private uint size()
        {
            uint ret = LandmarkDetectorPINVOKE.IntList2N_size(swigCPtr);
            return ret;
        }

        private uint capacity()
        {
            uint ret = LandmarkDetectorPINVOKE.IntList2N_capacity(swigCPtr);
            return ret;
        }

        private void reserve(uint n)
        {
            LandmarkDetectorPINVOKE.IntList2N_reserve(swigCPtr, n);
        }

        public IntList2N() : this(LandmarkDetectorPINVOKE.new_IntList2N__SWIG_0(), true)
        {
        }

        public IntList2N(IntList2N other) : this(LandmarkDetectorPINVOKE.new_IntList2N__SWIG_1(other.Pointer), true)
        {
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public IntList2N(int capacity) : this(LandmarkDetectorPINVOKE.new_IntList2N__SWIG_2(capacity), true)
        {
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        private IntList getitemcopy(int index)
        {
            IntList ret = new IntList(LandmarkDetectorPINVOKE.IntList2N_getitemcopy(swigCPtr, index), true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private IntList getitem(int index)
        {
            IntList ret = new IntList(LandmarkDetectorPINVOKE.IntList2N_getitem(swigCPtr, index), false);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        private void setitem(int index, IntList val)
        {
            LandmarkDetectorPINVOKE.IntList2N_setitem(swigCPtr, index, val.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void AddRange(IntList2N values)
        {
            LandmarkDetectorPINVOKE.IntList2N_AddRange(swigCPtr, values.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public IntList2N GetRange(int index, int count)
        {
            global::System.IntPtr cPtr = LandmarkDetectorPINVOKE.IntList2N_GetRange(swigCPtr, index, count);
            IntList2N ret = (cPtr == global::System.IntPtr.Zero) ? null : new IntList2N(cPtr, true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Insert(int index, IntList x)
        {
            LandmarkDetectorPINVOKE.IntList2N_Insert(swigCPtr, index, x.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void InsertRange(int index, IntList2N values)
        {
            LandmarkDetectorPINVOKE.IntList2N_InsertRange(swigCPtr, index, values.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void RemoveAt(int index)
        {
            LandmarkDetectorPINVOKE.IntList2N_RemoveAt(swigCPtr, index);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void RemoveRange(int index, int count)
        {
            LandmarkDetectorPINVOKE.IntList2N_RemoveRange(swigCPtr, index, count);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public static IntList2N Repeat(IntList value, int count)
        {
            global::System.IntPtr cPtr = LandmarkDetectorPINVOKE.IntList2N_Repeat(value.Pointer, count);
            IntList2N ret = (cPtr == global::System.IntPtr.Zero) ? null : new IntList2N(cPtr, true);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void Reverse()
        {
            LandmarkDetectorPINVOKE.IntList2N_Reverse__SWIG_0(swigCPtr);
        }

        public void Reverse(int index, int count)
        {
            LandmarkDetectorPINVOKE.IntList2N_Reverse__SWIG_1(swigCPtr, index, count);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetRange(int index, IntList2N values)
        {
            LandmarkDetectorPINVOKE.IntList2N_SetRange(swigCPtr, index, values.Pointer);
            if (LandmarkDetectorPINVOKE.SWIGPendingException.Pending) throw LandmarkDetectorPINVOKE.SWIGPendingException.Retrieve();
        }

    }

}
