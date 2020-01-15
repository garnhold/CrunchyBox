using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class FunctionSyncroExtensions_RoutedEventHandler
    {
        static public RoutedEventHandler GetRoutedEventHandler(this FunctionSyncro item, Predicate<RoutedEventArgs> predicate)
        {
            if(item.GetFunction().HasNoParameters())
            {
                return delegate(object sender, RoutedEventArgs e) {
                    if (predicate(e))
                        item.Execute();
                };
            }

            if (item.GetFunction().CanParametersHold<object, RoutedEventArgs>())
            {
                return delegate(object sender, RoutedEventArgs e) {
                    if (predicate(e))
                        item.Execute(new object[] { sender, e });
                };
            }

            if (item.GetFunction().CanParametersHold<RoutedEventArgs>())
            {
                return delegate(object sender, RoutedEventArgs e) {
                    if (predicate(e))
                        item.Execute(new object[] { e });
                };
            }

            throw new UnexpectedSignatureException(item.GetFunction().GetParameterTypes());
        }
        static public RoutedEventHandler GetRoutedEventHandler(this FunctionSyncro item)
        {
            return item.GetRoutedEventHandler(e => true);
        }
    }
}