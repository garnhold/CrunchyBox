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
    static public class BasicAvaloniaEngineInitilizer_DragDrop
    {
        [BasicAvaloniaEngineInitilizer]
        static public void Initilize(AvaloniaEngine engine)
        {
            engine.AddSimpleInstancer<DragHandler_Internal_Value>("DragHandler");
            engine.AddLinkInfo<DragHandler_Internal_Value, object>("value", (h, v) => h.SetValue(v), h => h.GetValue(), h => true);
            engine.AddLinkInfo<DragHandler, DragDropEffects>("drag_drop_effects", (h, e) => h.SetDragDropEffects(e), e => e.GetDragDropEffects(), h => true);

            engine.AddLinkInfo<Control, DragHandler>("drag_handler", (e, h) => e.SetDragHandler(h), e => e.GetDragHandler());

            engine.AddSimpleInstancer<DropHandler_Internal_FunctionSyncro>("DropHandler");
            engine.AddFunctionInfo<DropHandler_Internal_FunctionSyncro>("on_enter", (h, f) => h.SetOnEnter(f));
            engine.AddFunctionInfo<DropHandler_Internal_FunctionSyncro>("on_over", (h, f) => h.SetOnOver(f));
            engine.AddFunctionInfo<DropHandler_Internal_FunctionSyncro>("on_leave", (h, f) => h.SetOnLeave(f));
            engine.AddFunctionInfo<DropHandler_Internal_FunctionSyncro>("on_drop", (h, f) => h.SetOnDrop(f));

            engine.AddChildrenInfo<Control, DropHandler>("drop_handlers", (c, h) => c.SetDropHandlers(h));
        }
    }
}