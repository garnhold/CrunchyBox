using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Windows;
using System.Windows.Input;

namespace Crunchy.Sack.WPF
{
    using Dough;
    using Noodle;
    using Sack;
    using System;
    
    static public class UIElementExtensions_Drop
    {
        static private readonly AttachedObjectField<UIElement, List<DropHandler>> DROP_HANDLER_LIST_FIELD = new AttachedObjectField<UIElement, List<DropHandler>>();

        static public void AddDropHandler(this UIElement item, DropHandler to_add)
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

        static public void ClearDropHandlers(this UIElement item)
        {
            item.GetDropHandlers().Process(h => h.Detach());

            DROP_HANDLER_LIST_FIELD.SetValue(item, null);
        }

        static public IEnumerable<DropHandler> GetDropHandlers(this UIElement item)
        {
            return DROP_HANDLER_LIST_FIELD.GetValue(item) ?? Empty.IEnumerable<DropHandler>();
        }
    }
}