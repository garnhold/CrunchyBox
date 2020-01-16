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

            engine.Add(
                AvaloniaModifiers.General<Control>((ex, e) => e.DataContext = ex.GetTargetInfo().GetTarget()),

                AvaloniaInfos.AttributeValue<Control, bool>("auto_focus", (f, v) => f.Focus()),

                AvaloniaInfos.AttributeFunction<Control>("on_mouse_down", Control.PointerPressedEvent),
                AvaloniaInfos.AttributeFunction<Control>("on_mouse_up", Control.PointerReleasedEvent),
                AvaloniaInfos.AttributeFunction<Control>("on_mouse_move", Control.PointerMovedEvent)
            );
        }
    }
}