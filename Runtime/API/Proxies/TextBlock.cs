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

public class TextBlock : FrameworkElement {
  internal new static TextBlock CreateProxy(IntPtr cPtr, bool cMemoryOwn) {
    return new TextBlock(cPtr, cMemoryOwn);
  }

  internal TextBlock(IntPtr cPtr, bool cMemoryOwn) : base(cPtr, cMemoryOwn) {
  }

  internal static HandleRef getCPtr(TextBlock obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public Typography Typography {
    get { return new Typography(this); }
  }

  public override string ToString() {
    return ToStringHelper();
  }

  public TextBlock() {
  }

  protected override IntPtr CreateCPtr(Type type, out bool registerExtend) {
    if (type == typeof(TextBlock)) {
      registerExtend = false;
      return NoesisGUI_PINVOKE.new_TextBlock__SWIG_0();
    }
    else {
      return base.CreateExtendCPtr(type, out registerExtend);
    }
  }

  public TextBlock(string text) : this(NoesisGUI_PINVOKE.new_TextBlock__SWIG_1(text != null ? text : string.Empty), true) {
  }

  public static DependencyProperty BackgroundProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_BackgroundProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty CharacterSpacingProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_CharacterSpacingProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty FontFamilyProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_FontFamilyProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty FontSizeProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_FontSizeProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty FontStretchProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_FontStretchProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty FontStyleProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_FontStyleProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty FontWeightProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_FontWeightProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty ForegroundProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_ForegroundProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty LineHeightProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_LineHeightProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty LineStackingStrategyProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_LineStackingStrategyProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty PaddingProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_PaddingProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty StrokeProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_StrokeProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty StrokeThicknessProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_StrokeThicknessProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty TextAlignmentProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_TextAlignmentProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty TextDecorationsProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_TextDecorationsProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty TextProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_TextProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty TextTrimmingProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_TextTrimmingProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public static DependencyProperty TextWrappingProperty {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_TextWrappingProperty_get();
      return (DependencyProperty)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public Brush Background {
    set {
      NoesisGUI_PINVOKE.TextBlock_Background_set(swigCPtr, Brush.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_Background_get(swigCPtr);
      return (Brush)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public int CharacterSpacing {
    set {
      NoesisGUI_PINVOKE.TextBlock_CharacterSpacing_set(swigCPtr, value);
    } 
    get {
      int ret = NoesisGUI_PINVOKE.TextBlock_CharacterSpacing_get(swigCPtr);
      return ret;
    } 
  }

  public FontFamily FontFamily {
    set {
      NoesisGUI_PINVOKE.TextBlock_FontFamily_set(swigCPtr, FontFamily.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_FontFamily_get(swigCPtr);
      return (FontFamily)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public float FontSize {
    set {
      NoesisGUI_PINVOKE.TextBlock_FontSize_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.TextBlock_FontSize_get(swigCPtr);
      return ret;
    } 
  }

  public FontStretch FontStretch {
    set {
      NoesisGUI_PINVOKE.TextBlock_FontStretch_set(swigCPtr, (int)value);
    } 
    get {
      FontStretch ret = (FontStretch)NoesisGUI_PINVOKE.TextBlock_FontStretch_get(swigCPtr);
      return ret;
    } 
  }

  public FontStyle FontStyle {
    set {
      NoesisGUI_PINVOKE.TextBlock_FontStyle_set(swigCPtr, (int)value);
    } 
    get {
      FontStyle ret = (FontStyle)NoesisGUI_PINVOKE.TextBlock_FontStyle_get(swigCPtr);
      return ret;
    } 
  }

  public FontWeight FontWeight {
    set {
      NoesisGUI_PINVOKE.TextBlock_FontWeight_set(swigCPtr, (int)value);
    } 
    get {
      FontWeight ret = (FontWeight)NoesisGUI_PINVOKE.TextBlock_FontWeight_get(swigCPtr);
      return ret;
    } 
  }

  public Brush Foreground {
    set {
      NoesisGUI_PINVOKE.TextBlock_Foreground_set(swigCPtr, Brush.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_Foreground_get(swigCPtr);
      return (Brush)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public InlineCollection Inlines {
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_Inlines_get(swigCPtr);
      return (InlineCollection)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public float LineHeight {
    set {
      NoesisGUI_PINVOKE.TextBlock_LineHeight_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.TextBlock_LineHeight_get(swigCPtr);
      return ret;
    } 
  }

  public LineStackingStrategy LineStackingStrategy {
    set {
      NoesisGUI_PINVOKE.TextBlock_LineStackingStrategy_set(swigCPtr, (int)value);
    } 
    get {
      LineStackingStrategy ret = (LineStackingStrategy)NoesisGUI_PINVOKE.TextBlock_LineStackingStrategy_get(swigCPtr);
      return ret;
    } 
  }

  public Thickness Padding {
    set {
      NoesisGUI_PINVOKE.TextBlock_Padding_set(swigCPtr, ref value);
    }

    get {
      IntPtr ret = NoesisGUI_PINVOKE.TextBlock_Padding_get(swigCPtr);
      if (ret != IntPtr.Zero) {
        return Marshal.PtrToStructure<Thickness>(ret);
      }
      else {
        return new Thickness();
      }
    }

  }

  public Brush Stroke {
    set {
      NoesisGUI_PINVOKE.TextBlock_Stroke_set(swigCPtr, Brush.getCPtr(value));
    } 
    get {
      IntPtr cPtr = NoesisGUI_PINVOKE.TextBlock_Stroke_get(swigCPtr);
      return (Brush)Noesis.Extend.GetProxy(cPtr, false);
    }
  }

  public float StrokeThickness {
    set {
      NoesisGUI_PINVOKE.TextBlock_StrokeThickness_set(swigCPtr, value);
    } 
    get {
      float ret = NoesisGUI_PINVOKE.TextBlock_StrokeThickness_get(swigCPtr);
      return ret;
    } 
  }

  public TextAlignment TextAlignment {
    set {
      NoesisGUI_PINVOKE.TextBlock_TextAlignment_set(swigCPtr, (int)value);
    } 
    get {
      TextAlignment ret = (TextAlignment)NoesisGUI_PINVOKE.TextBlock_TextAlignment_get(swigCPtr);
      return ret;
    } 
  }

  public string Text {
    set {
      NoesisGUI_PINVOKE.TextBlock_Text_set(swigCPtr, value != null ? value : string.Empty);
    }
    get {
      IntPtr strPtr = NoesisGUI_PINVOKE.TextBlock_Text_get(swigCPtr);
      string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
      return str;
    }
  }

  public TextDecorations TextDecorations {
    set {
      NoesisGUI_PINVOKE.TextBlock_TextDecorations_set(swigCPtr, (int)value);
    } 
    get {
      TextDecorations ret = (TextDecorations)NoesisGUI_PINVOKE.TextBlock_TextDecorations_get(swigCPtr);
      return ret;
    } 
  }

  public TextTrimming TextTrimming {
    set {
      NoesisGUI_PINVOKE.TextBlock_TextTrimming_set(swigCPtr, (int)value);
    } 
    get {
      TextTrimming ret = (TextTrimming)NoesisGUI_PINVOKE.TextBlock_TextTrimming_get(swigCPtr);
      return ret;
    } 
  }

  public TextWrapping TextWrapping {
    set {
      NoesisGUI_PINVOKE.TextBlock_TextWrapping_set(swigCPtr, (int)value);
    } 
    get {
      TextWrapping ret = (TextWrapping)NoesisGUI_PINVOKE.TextBlock_TextWrapping_get(swigCPtr);
      return ret;
    } 
  }

  private string ToStringHelper() {
    IntPtr strPtr = NoesisGUI_PINVOKE.TextBlock_ToStringHelper(swigCPtr);
    string str = Noesis.Extend.StringFromNativeUtf8(strPtr);
    NoesisGUI_PINVOKE.FreeString(strPtr);
    return str;
  }

  internal new static IntPtr Extend(string typeName) {
    return NoesisGUI_PINVOKE.Extend_TextBlock(Marshal.StringToHGlobalAnsi(typeName));
  }
}

}

