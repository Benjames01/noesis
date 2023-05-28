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

namespace Noesis
{

public class PathSegment : Animatable {
  internal new static PathSegment CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new PathSegment(cPtr, cMemoryOwn);
  }

  internal PathSegment(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(PathSegment obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  protected PathSegment() {
  }

  public static DependencyProperty IsSmoothJoinProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PathSegment_IsSmoothJoinProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty IsStrokedProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.PathSegment_IsStrokedProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public bool IsSmoothJoin {
    set {
      NoesisGUI_PINVOKE.PathSegment_IsSmoothJoin_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.PathSegment_IsSmoothJoin_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsStroked {
    set {
      NoesisGUI_PINVOKE.PathSegment_IsStroked_set(swigCPtr, value);
    } 
    get {
      bool ret = NoesisGUI_PINVOKE.PathSegment_IsStroked_get(swigCPtr);
      return ret;
    } 
  }

}

}

