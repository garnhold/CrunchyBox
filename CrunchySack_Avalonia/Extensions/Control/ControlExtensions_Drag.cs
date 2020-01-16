using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    using System;
    
    static public class ControlExtensions_Drag
    {
        static private readonly AttachedObjectField<Control, DragHandler> DRAG_HANDLER_FIELD = new AttachedObjectField<Control, DragHandler>(null);

        static public void SetDragHandler(this Control item, DragHandler to_set)
        {
            DRAG_HANDLER_FIELD.GetValue(item).IfNotNull(h => h.Detach());
            DRAG_HANDLER_FIELD.SetValue(item, to_set);

            if (to_set != null)
                to_set.Attach(item);
        }

        static public DragHandler GetDragHandler(this Control item)
        {
            return DRAG_HANDLER_FIELD.GetValue(item);
        }
    }
}