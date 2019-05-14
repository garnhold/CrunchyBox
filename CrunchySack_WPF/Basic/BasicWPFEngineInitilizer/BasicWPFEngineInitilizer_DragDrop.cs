using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_WPF
{
    [BasicWPFEngineInitilizer]
    static public class BasicWPFEngineInitilizer_DragDrop
    {
        [BasicWPFEngineInitilizer]
        static public void Initilize(WPFEngine engine)
        {
            engine.Add(
                WPFInstancers.Simple("DragHandler", () => new DragHandler_Internal_Value()),

                WPFInfos.AttributeLink<DragHandler_Internal_Value, object>("value", (h, v) => h.SetValue(v), h => h.GetValue(), h => true),
                WPFInfos.AttributeLink<DragHandler, DragDropEffects>("drag_drop_effects", (h, e) => h.SetDragDropEffects(e), e => e.GetDragDropEffects(), h => true),

                WPFInfos.AttributeLink<UIElement, DragHandler>("drag_handler", (e, h) => e.SetDragHandler(h), e => e.GetDragHandler())
            );

            engine.Add(
                WPFInstancers.Simple("DropHandler", () => new DropHandler_Internal_FunctionSyncro()),

                WPFInfos.AttributeFunction<DropHandler_Internal_FunctionSyncro>("on_enter", (h, f) => h.SetOnEnter(f)),
                WPFInfos.AttributeFunction<DropHandler_Internal_FunctionSyncro>("on_over", (h, f) => h.SetOnOver(f)),
                WPFInfos.AttributeFunction<DropHandler_Internal_FunctionSyncro>("on_leave", (h, f) => h.SetOnLeave(f)),
                WPFInfos.AttributeFunction<DropHandler_Internal_FunctionSyncro>("on_drop", (h, f) => h.SetOnDrop(f)),

                WPFInfos.AttributeChildren<UIElement, DropHandler>("drop_handlers", e => e.ClearDropHandlers(), (e, h) => e.AddDropHandler(h))
            );
        }
    }
}