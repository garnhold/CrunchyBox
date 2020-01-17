using System;
using System.IO;

using System.Windows;

namespace Crunchy.Sack_WinCommon
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class FunctionSyncroExtensions_EventHandler
    {
        static public EventHandler GetEventHandler(this FunctionSyncro item, Predicate<EventArgs> predicate)
        {
            if(item.GetFunction().HasNoParameters())
            {
                return delegate(object sender, EventArgs e) {
                    if (predicate(e))
                        item.Execute();
                };
            }

            if (item.GetFunction().GetNumberParameters() == 1)
            {
                return delegate (object sender, EventArgs e) {
                    if (predicate(e))
                        item.Execute(new object[] { e });
                };
            }

            if (item.GetFunction().GetNumberParameters() == 2)
            {
                return delegate(object sender, EventArgs e) {
                    if (predicate(e))
                        item.Execute(new object[] { sender, e });
                };
            }

            throw new UnexpectedSignatureException(item.GetFunction().GetParameterTypes());
        }
        static public EventHandler GetEventHandler(this FunctionSyncro item)
        {
            return item.GetEventHandler(e => true);
        }
    }
}