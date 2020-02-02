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

            engine.AddAttributeValue<Control, bool>("auto_focus", (c, v) => v.IfTrue(() => c.Focus()));

            engine.AddAttributeFunction<Control>("on_mouse_down", Control.PointerPressedEvent);
            engine.AddAttributeFunction<Control>("on_mouse_up", Control.PointerReleasedEvent);
            engine.AddAttributeFunction<Control>("on_mouse_move", Control.PointerMovedEvent);

            engine.AddAttributeFunction<Control>("on_click", Control.TappedEvent);
            engine.AddAttributeFunction<Control>("on_double_click", Control.DoubleTappedEvent);
        }
    }
}