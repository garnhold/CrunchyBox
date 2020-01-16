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
    static public class BasicAvaloniaEngineInitilizer_DragDrop
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.Add(
                AvaloniaInstancers.Simple("DragHandler", () => new DragHandler_Internal_Value()),

                AvaloniaInfos.AttributeLink<DragHandler_Internal_Value, object>("value", (h, v) => h.SetValue(v), h => h.GetValue(), h => true),
                AvaloniaInfos.AttributeLink<DragHandler, DragDropEffects>("drag_drop_effects", (h, e) => h.SetDragDropEffects(e), e => e.GetDragDropEffects(), h => true),

                AvaloniaInfos.AttributeLink<Control, DragHandler>("drag_handler", (e, h) => e.SetDragHandler(h), e => e.GetDragHandler())
            );

            engine.Add(
                AvaloniaInstancers.Simple("DropHandler", () => new DropHandler_Internal_FunctionSyncro()),

                AvaloniaInfos.AttributeFunction<DropHandler_Internal_FunctionSyncro>("on_enter", (h, f) => h.SetOnEnter(f)),
                AvaloniaInfos.AttributeFunction<DropHandler_Internal_FunctionSyncro>("on_over", (h, f) => h.SetOnOver(f)),
                AvaloniaInfos.AttributeFunction<DropHandler_Internal_FunctionSyncro>("on_leave", (h, f) => h.SetOnLeave(f)),
                AvaloniaInfos.AttributeFunction<DropHandler_Internal_FunctionSyncro>("on_drop", (h, f) => h.SetOnDrop(f)),

                AvaloniaInfos.AttributeChildren<Control, DropHandler>("drop_handlers", e => e.ClearDropHandlers(), (e, h) => e.AddDropHandler(h))
            );
        }
    }
}