//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class DoubleMat_List2N : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<DoubleMat_List>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DoubleMat_List2N(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DoubleMat_List2N obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DoubleMat_List2N() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LaandmrkDetectorPINVOKE.delete_DoubleMat_List2N(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public DoubleMat_List2N(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (DoubleMat_List element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public DoubleMat_List this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(DoubleMat_List[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(DoubleMat_List[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, DoubleMat_List[] array, int arrayIndex, int count)
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

  global::System.Collections.Generic.IEnumerator<DoubleMat_List> global::System.Collections.Generic.IEnumerable<DoubleMat_List>.GetEnumerator() {
    return new DoubleMat_List2NEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new DoubleMat_List2NEnumerator(this);
  }

  public DoubleMat_List2NEnumerator GetEnumerator() {
    return new DoubleMat_List2NEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class DoubleMat_List2NEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<DoubleMat_List>
  {
    private DoubleMat_List2N collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public DoubleMat_List2NEnumerator(DoubleMat_List2N collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public DoubleMat_List Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (DoubleMat_List)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    LaandmrkDetectorPINVOKE.DoubleMat_List2N_Clear(swigCPtr);
  }

  public void Add(DoubleMat_List x) {
    LaandmrkDetectorPINVOKE.DoubleMat_List2N_Add(swigCPtr, DoubleMat_List.getCPtr(x));
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = LaandmrkDetectorPINVOKE.DoubleMat_List2N_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = LaandmrkDetectorPINVOKE.DoubleMat_List2N_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    LaandmrkDetectorPINVOKE.DoubleMat_List2N_reserve(swigCPtr, n);
  }

  public DoubleMat_List2N() : this(LaandmrkDetectorPINVOKE.new_DoubleMat_List2N__SWIG_0(), true) {
  }

  public DoubleMat_List2N(DoubleMat_List2N other) : this(LaandmrkDetectorPINVOKE.new_DoubleMat_List2N__SWIG_1(DoubleMat_List2N.getCPtr(other)), true) {
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public DoubleMat_List2N(int capacity) : this(LaandmrkDetectorPINVOKE.new_DoubleMat_List2N__SWIG_2(capacity), true) {
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  private DoubleMat_List getitemcopy(int index) {
    DoubleMat_List ret = new DoubleMat_List(LaandmrkDetectorPINVOKE.DoubleMat_List2N_getitemcopy(swigCPtr, index), true);
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private DoubleMat_List getitem(int index) {
    DoubleMat_List ret = new DoubleMat_List(LaandmrkDetectorPINVOKE.DoubleMat_List2N_getitem(swigCPtr, index), false);
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, DoubleMat_List val) {
    LaandmrkDetectorPINVOKE.DoubleMat_List2N_setitem(swigCPtr, index, DoubleMat_List.getCPtr(val));
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(DoubleMat_List2N values) {
    LaandmrkDetectorPINVOKE.DoubleMat_List2N_AddRange(swigCPtr, DoubleMat_List2N.getCPtr(values));
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public DoubleMat_List2N GetRange(int index, int count) {
    global::System.IntPtr cPtr = LaandmrkDetectorPINVOKE.DoubleMat_List2N_GetRange(swigCPtr, index, count);
    DoubleMat_List2N ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleMat_List2N(cPtr, true);
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, DoubleMat_List x) {
    LaandmrkDetectorPINVOKE.DoubleMat_List2N_Insert(swigCPtr, index, DoubleMat_List.getCPtr(x));
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, DoubleMat_List2N values) {
    LaandmrkDetectorPINVOKE.DoubleMat_List2N_InsertRange(swigCPtr, index, DoubleMat_List2N.getCPtr(values));
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    LaandmrkDetectorPINVOKE.DoubleMat_List2N_RemoveAt(swigCPtr, index);
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    LaandmrkDetectorPINVOKE.DoubleMat_List2N_RemoveRange(swigCPtr, index, count);
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public static DoubleMat_List2N Repeat(DoubleMat_List value, int count) {
    global::System.IntPtr cPtr = LaandmrkDetectorPINVOKE.DoubleMat_List2N_Repeat(DoubleMat_List.getCPtr(value), count);
    DoubleMat_List2N ret = (cPtr == global::System.IntPtr.Zero) ? null : new DoubleMat_List2N(cPtr, true);
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    LaandmrkDetectorPINVOKE.DoubleMat_List2N_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    LaandmrkDetectorPINVOKE.DoubleMat_List2N_Reverse__SWIG_1(swigCPtr, index, count);
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, DoubleMat_List2N values) {
    LaandmrkDetectorPINVOKE.DoubleMat_List2N_SetRange(swigCPtr, index, DoubleMat_List2N.getCPtr(values));
    if (LaandmrkDetectorPINVOKE.SWIGPendingException.Pending) throw LaandmrkDetectorPINVOKE.SWIGPendingException.Retrieve();
  }

}
