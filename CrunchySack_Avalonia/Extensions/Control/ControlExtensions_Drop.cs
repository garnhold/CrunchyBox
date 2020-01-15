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
    
    static public class ControlExtensions_Drop
    {
        static private readonly AttachedObjectField<Control, List<DropHandler>> DROP_HANDLER_LIST_FIELD = new AttachedObjectField<Control, List<DropHandler>>();

        static public void AddDropHandler(this Control item, DropHandler to_add)
        {
            List<DropHandler> drop_handlers = DROP_HANDLER_LIST_FIELD.GetValue(item);

            if (drop_handlers == null)
            {
                drop_handlers = new List<DropHandler>();

                DROP_HANDLER_LIST_FIELD.SetValue(item, drop_handlers);
            }

            drop_handlers.Add(to_add);
            to_add.Attach(item);
        }

        static public void ClearDropHandlers(this Control item)
        {
            item.GetDropHandlers().Process(h => h.Detach());

            DROP_HANDLER_LIST_FIELD.SetValue(item, null);
        }

        static public IEnumerable<DropHandler> GetDropHandlers(this Control item)
        {
            return DROP_HANDLER_LIST_FIELD.GetValue(item) ?? Empty.IEnumerable<DropHandler>();
        }
    }
}