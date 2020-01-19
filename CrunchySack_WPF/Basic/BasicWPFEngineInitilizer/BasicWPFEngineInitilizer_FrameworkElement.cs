using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Sack;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_General
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.AddGeneralModifier<FrameworkElement>((ex, e) => e.DataContext = ex.GetTargetInfo().GetTarget());

            engine.AddAttributeValue<FrameworkElement, bool>("auto_focus", (f, v) => f.Focus());

            engine.AddAttributeFunction<FrameworkElement>("bind_left_click", (f, a) => f.AddInputBinding(a, MouseAction.LeftClick));
            engine.AddAttributeFunction<FrameworkElement>("bind_left_double_click", (f, a) => f.AddInputBinding(a, MouseAction.LeftDoubleClick));
        }
    }
}