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

public class Ellipse : Shape {
  internal new static Ellipse CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new Ellipse(cPtr, cMemoryOwn);
  }

  internal Ellipse(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(Ellipse obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  internal protected override Geometry DefiningGeometry {
    get { return new EllipseGeometry(); }
  }

  public Ellipse() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    registerExtend = false;
    return NoesisGUI_PINVOKE.new_Ellipse();
  }

}

}

