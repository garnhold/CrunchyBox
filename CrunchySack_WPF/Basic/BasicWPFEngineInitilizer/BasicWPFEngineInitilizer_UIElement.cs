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
    static public class BasicWPFEngineInitilizer_UIElement
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.Add(
                WPFInfos.AttributeFunction<UIElement>("on_mouse_down", (e, f) => e.MouseDown += f.GetMouseButtonEventHandler()),
                WPFInfos.AttributeFunction<UIElement>("on_mouse_down_update", (e, f) => e.MouseMove += f.GetMouseEventHandler(z => z.IsPressed())),

                WPFInfos.AttributeFunction<UIElement>("on_mouse_move", (e, f) => e.MouseMove += f.GetMouseEventHandler()),

                WPFInfos.AttributeFunction<UIElement>("on_mouse_up", (e, f) => e.MouseUp += f.GetMouseButtonEventHandler()),
                WPFInfos.AttributeFunction<UIElement>("on_mouse_up_update", (e, f) => e.MouseMove += f.GetMouseEventHandler(z => z.IsPressed() == false))
            );
        }
    }
}