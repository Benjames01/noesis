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

public class RiveInput : Animatable {
  internal new static RiveInput CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new RiveInput(cPtr, cMemoryOwn);
  }

  internal RiveInput(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(RiveInput obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public RiveInput() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_RiveInput();
  }

  public static DependencyProperty InputNameProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.RiveInput_InputNameProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty InputValueProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.RiveInput_InputValueProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public string InputName {
    set {
      NoesisGUI_PINVOKE.RiveInput_InputName_set(swigCPtr, value != null ? value : string.Empty);
    }
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.RiveInput_InputName_get(swigCPtr);
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  public object InputValue {
    set {
      NoesisGUI_PINVOKE.RiveInput_InputValue_set(swigCPtr, Noesis.Extend.GetInstanceHandle(value));
    }
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.RiveInput_InputValue_get(swigCPtr);
      return Noesis.Extend.GetProxy(cPtr, false);
    }
  }

}

}

