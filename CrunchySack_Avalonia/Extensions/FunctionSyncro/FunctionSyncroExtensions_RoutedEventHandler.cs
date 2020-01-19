using System;
using System.IO;

using Avalonia;
using Avalonia.Interactivity;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class FunctionSyncroExtensions_RoutedEventHandler
    {
        static public EventHandler<T> GetRoutedEventHandler<T>(this FunctionSyncro item, Predicate<T> predicate) where T : RoutedEventArgs
        {
            if(item.GetFunction().HasNoParameters())
            {
                return delegate(object sender, T e) {
                    if (predicate(e))
                    {
                        item.Execute();
                        e.Handled = true;
                    }
                };
            }

            if (item.GetFunction().GetNumberParameters() == 1)
            {
                return delegate (object sender, T e) {
                    if (predicate(e))
                    {
                        item.Execute(new object[] { e });
                        e.Handled = true;
                    }
                };
            }

            if (item.GetFunction().GetNumberParameters() == 2)
            {
                return delegate(object sender, T e) {
                    if (predicate(e))
                    {
                        item.Execute(new object[] { sender, e });
                        e.Handled = true;
                    }
                };
            }

            throw new UnexpectedSignatureException(item.GetFunction().GetParameterTypes());
        }
        static public EventHandler<T> GetRoutedEventHandler<T>(this FunctionSyncro item) where T : RoutedEventArgs
        {
            return item.GetRoutedEventHandler<T>(e => true);
        }
    }
}