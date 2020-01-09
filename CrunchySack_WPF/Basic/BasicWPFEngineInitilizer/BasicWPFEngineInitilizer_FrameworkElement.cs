using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Crunchy.Sack.WPF
{
    using Dough;
    using Sack;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_General
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.Add(
                WPFModifiers.General<FrameworkElement>((ex, e) => e.DataContext = ex.GetTargetInfo().GetTarget()),

                WPFInfos.AttributeValue<FrameworkElement, bool>("auto_focus", (f, v) => f.Focus()),

                WPFInfos.AttributeFunction<FrameworkElement>("bind_left_click", (f, a) => f.AddInputBinding(a, MouseAction.LeftClick)),
                WPFInfos.AttributeFunction<FrameworkElement>("bind_left_double_click", (f, a) => f.AddInputBinding(a, MouseAction.LeftDoubleClick))
            );
        }
    }
}