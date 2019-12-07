using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Windows;
using System.Windows.Input;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Noodle;
    using Sack;
    using System;
    
    static public class UIElementExtensions_Drag
    {
        static private readonly AttachedObjectField<UIElement, DragHandler> DRAG_HANDLER_FIELD = new AttachedObjectField<UIElement, DragHandler>();

        static public void SetDragHandler(this UIElement item, DragHandler to_set)
        {
            DRAG_HANDLER_FIELD.GetValue(item).IfNotNull(h => h.Detach());
            DRAG_HANDLER_FIELD.SetValue(item, to_set);

            if (to_set != null)
                to_set.Attach(item);
        }

        static public DragHandler GetDragHandler(this UIElement item)
        {
            return DRAG_HANDLER_FIELD.GetValue(item);
        }
    }
}