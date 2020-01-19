using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Sack;
    
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_DragDrop
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.AddSimpleInstancer<DragHandler_Internal_Value>("DragHandler");

            engine.AddAttributeLink<DragHandler_Internal_Value, object>("value", (h, v) => h.SetValue(v), h => h.GetValue(), h => true);
            engine.AddAttributeLink<DragHandler, DragDropEffects>("drag_drop_effects", (h, e) => h.SetDragDropEffects(e), e => e.GetDragDropEffects(), h => true);

            engine.AddAttributeLink<UIElement, DragHandler>("drag_handler", (e, h) => e.SetDragHandler(h), e => e.GetDragHandler());

            engine.AddSimpleInstancer<DropHandler_Internal_FunctionSyncro>("DropHandler");

            engine.AddAttributeFunction<DropHandler_Internal_FunctionSyncro>("on_enter", (h, f) => h.SetOnEnter(f));
            engine.AddAttributeFunction<DropHandler_Internal_FunctionSyncro>("on_over", (h, f) => h.SetOnOver(f));
            engine.AddAttributeFunction<DropHandler_Internal_FunctionSyncro>("on_leave", (h, f) => h.SetOnLeave(f));
            engine.AddAttributeFunction<DropHandler_Internal_FunctionSyncro>("on_drop", (h, f) => h.SetOnDrop(f));

            engine.AddAttributeChildren<UIElement, DropHandler>("drop_handlers", e => e.ClearDropHandlers(), (e, h) => e.AddDropHandler(h));
        }
    }
}