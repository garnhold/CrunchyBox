using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Sack;
    
    [BasicAvaloniaEngineInitilizer]
    static public class BasicAvaloniaEngineInitilizer_Control
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddAvaloniaPropertyAttributeLinksForType<Control>();
            engine.AddGeneralModifier<Control>((ex, c) => c.DataContext = ex.GetTargetInfo().GetTarget());

            engine.AddValueInfo<Control, bool>("auto_focus", (c, v) => v.IfTrue(() => c.Focus()));

            engine.AddFunctionInfo<Control>("on_mouse_down", Control.PointerPressedEvent);
            engine.AddFunctionInfo<Control>("on_mouse_up", Control.PointerReleasedEvent);
            engine.AddFunctionInfo<Control>("on_mouse_move", Control.PointerMovedEvent);

            engine.AddFunctionInfo<Control>("on_click", Control.TappedEvent);
            engine.AddFunctionInfo<Control>("on_double_click", Control.DoubleTappedEvent);
        }
    }
}