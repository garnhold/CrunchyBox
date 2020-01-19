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
    using Sack_WinCommon;
    
    [BasicAvaloniaEngineInitilizer]
    static public class BasicAvaloniaEngineInitilizer_Control
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddAvaloniaPropertyAttributeLinksForType<Control>();
            engine.AddGeneralModifier<Control>((ex, c) => c.DataContext = ex.GetTargetInfo().GetTarget());

            engine.AddAttributeValue<Control, bool>("auto_focus", (c, v) => c.Focus());

            engine.AddAttributeFunction<Control>("on_mouse_down", Control.PointerPressedEvent);
            engine.AddAttributeFunction<Control>("on_mouse_up", Control.PointerReleasedEvent);
            engine.AddAttributeFunction<Control>("on_mouse_move", Control.PointerMovedEvent);
        }
    }
}