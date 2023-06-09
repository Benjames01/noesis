//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


using System;
using System.Runtime.InteropServices;
using System.Collections;

namespace Noesis
{

public class BaseFreezableCollection : Animatable, IList {
  internal new static BaseFreezableCollection CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new BaseFreezableCollection(cPtr, cMemoryOwn);
  }

  internal BaseFreezableCollection(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(BaseFreezableCollection obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected BaseFreezableCollection() {
  }

  #region IList
  object IList.this[int index] {
    get { return this[index]; }
    set { this[index] = value; }
  }

  int IList.Add(object value) {
    return this.Add(value);
  }

  bool IList.Contains(object value) {
    return this.Contains(value);
  }

  void IList.Clear() {
    this.Clear();
  }

  bool IList.IsReadOnly {
    get { return this.IsReadOnly; }
  }

  bool IList.IsFixedSize {
    get { return false; }
  }

  int IList.IndexOf(object value) {
    return this.IndexOf(value);
  }

  void IList.Insert(int index, object value) {
    this.Insert(index, value);
  }

  void IList.Remove(object value) {
    this.Remove(value);
  }

  void IList.RemoveAt(int index) {
    this.RemoveAt(index);
  }
  #endregion

  #region ICollection
  int ICollection.Count {
    get { return this.Count; }
  }

  bool ICollection.IsSynchronized {
    get { return false; }
  }

  object ICollection.SyncRoot {
    get { return null; }
  }

  void ICollection.CopyTo(Array array, int arrayIndex) {
    this.CopyTo(array, arrayIndex);
  }
  #endregion

  #region Enumerator
  public Enumerator GetEnumerator() {
    return new Enumerator(this);
  }

  IEnumerator IEnumerable.GetEnumerator() {
    return new Enumerator(this);
  }

  public struct Enumerator : IEnumerator {
    object IEnumerator.Current {
      get { return Current; }
    }
    public object Current {
      get { return this._collection[this._index]; }
    }
    public bool MoveNext() {
      if (++this._index >= this._collection.Count) {
        return false;
      }
      return true;
    }
    public void Reset() {
      this._index = -1;
    }
    public Enumerator(BaseFreezableCollection c) {
      this._collection = c;
      this._index = -1;
    }
    private BaseFreezableCollection _collection;
    private int _index;
  }
  #endregion

  public object this[int index] {
    get {
      if (index >= Count) {
        throw new ArgumentOutOfRangeException("index");
      }
      IntPtr cPtr = Get(index);
      return Noesis.Extend.GetProxy(cPtr, true);
    }
    set {
      if (index >= Count) {
        throw new ArgumentOutOfRangeException("index");
      }
      Set(index, value);
    }
  }

  public bool IsReadOnly {
    get { return base.IsFrozen; }
  }

  public void CopyTo(Array array, int arrayIndex) {
    if (array == null) {
      throw new ArgumentNullException("array");
    }
    if (arrayIndex < 0) {
      throw new ArgumentOutOfRangeException("arrayIndex is less than 0.");
    }
    if ((array != null) && (array.Rank != 1)) {
      throw new ArgumentException("array is multidimensional.");
    }
    if (array.Length - arrayIndex < Count) { 
      throw new ArgumentException("There is no available space in array to copy all elements in the ICollection.");
    }
    int numElements = Count;
    for (int i = 0; i < numElements; ++i) {
      array.SetValue(this[i], arrayIndex + i);
    }
  }

  private void Set(int index, object item) {
    NoesisGUI_PINVOKE.BaseFreezableCollection_Set(swigCPtr, index, Noesis.Extend.GetInstanceHandle(item));
  }

  public int Add(object item) {
    int ret = NoesisGUI_PINVOKE.BaseFreezableCollection_Add(swigCPtr, Noesis.Extend.GetInstanceHandle(item));
    return ret;
  }

  public void Insert(int index, object item) {
    NoesisGUI_PINVOKE.BaseFreezableCollection_Insert(swigCPtr, index, Noesis.Extend.GetInstanceHandle(item));
  }

  public int IndexOf(object item) {
    int ret = NoesisGUI_PINVOKE.BaseFreezableCollection_IndexOf(swigCPtr, Noesis.Extend.GetInstanceHandle(item));
    return ret;
  }

  public void RemoveAt(int index) {
    NoesisGUI_PINVOKE.BaseFreezableCollection_RemoveAt(swigCPtr, index);
  }

  public void Clear() {
    NoesisGUI_PINVOKE.BaseFreezableCollection_Clear(swigCPtr);
  }

  public int Count {
    get {
      int ret = NoesisGUI_PINVOKE.BaseFreezableCollection_Count_get(swigCPtr);
      return ret;
    } 
  }

  public bool Contains(object item) {
    bool ret = NoesisGUI_PINVOKE.BaseFreezableCollection_Contains(swigCPtr, Noesis.Extend.GetInstanceHandle(item));
    return ret;
  }

  public bool Remove(object item) {
    bool ret = NoesisGUI_PINVOKE.BaseFreezableCollection_Remove(swigCPtr, Noesis.Extend.GetInstanceHandle(item));
    return ret;
  }

  private IntPtr Get(int index) {
    IntPtr ret = NoesisGUI_PINVOKE.BaseFreezableCollection_Get(swigCPtr, index);
    return ret;
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_BaseFreezableCollection(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

