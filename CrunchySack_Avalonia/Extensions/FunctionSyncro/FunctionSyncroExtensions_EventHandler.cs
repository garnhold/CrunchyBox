using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class FunctionSyncroExtensions_EventHandler
    {
        static public EventHandler<T> GetEventHandler<T>(this FunctionSyncro item, Predicate<T> predicate)
        {
            if(item.GetFunction().HasNoParameters())
            {
                return delegate(object sender, T e) {
                    if (predicate(e))
                        item.Execute();
                };
            }

            if (item.GetFunction().CanParametersHold<object, T>())
            {
                return delegate(object sender, T e) {
                    if (predicate(e))
                        item.Execute(new object[] { sender, e });
                };
            }

            if (item.GetFunction().CanParametersHold<T>())
            {
                return delegate(object sender, T e) {
                    if (predicate(e))
                        item.Execute(new object[] { e });
                };
            }

            throw new UnexpectedSignatureException(item.GetFunction().GetParameterTypes());
        }
        static public EventHandler<T> GetEventHandler<T>(this FunctionSyncro item)
        {
            return item.GetEventHandler<T>(e => true);
        }
    }
}