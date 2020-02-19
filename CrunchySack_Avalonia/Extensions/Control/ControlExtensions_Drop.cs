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
        static private readonly AttachedObjectField<Control, List<DropHandler>> DROP_HANDLER_LIST_FIELD = new AttachedObjectField<Control, List<DropHandler>>(delegate(Control control) {
            return new List<DropHandler>();
        });

        static public void SetDropHandlers(this Control item, IEnumerable<DropHandler> drop_handlers)
        {
            item.ClearDropHandlers();
            drop_handlers.Process(h => item.AddDropHandler(h));
        }

        static public void AddDropHandler(this Control item, DropHandler to_add)
        {
            DROP_HANDLER_LIST_FIELD.GetValue(item).Add(to_add);
            to_add.Attach(item);
        }

        static public void ClearDropHandlers(this Control item)
        {
            DROP_HANDLER_LIST_FIELD.GetValue(item)
                .ProcessAndChain(h => h.Detach())
                .Clear();
        }

        static public IEnumerable<DropHandler> GetDropHandlers(this Control item)
        {
            return DROP_HANDLER_LIST_FIELD.GetValue(item);
        }
    }
}