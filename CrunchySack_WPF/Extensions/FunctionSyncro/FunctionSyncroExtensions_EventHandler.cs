using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySack;

namespace CrunchySack_WPF
{
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

            if (item.GetFunction().CanParametersHold<object, EventArgs>())
            {
                return delegate(object sender, EventArgs e) {
                    if (predicate(e))
                        item.Execute(new object[] { sender, e });
                };
            }

            if (item.GetFunction().CanParametersHold<EventArgs>())
            {
                return delegate(object sender, EventArgs e) {
                    if (predicate(e))
                        item.Execute(new object[] { e });
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