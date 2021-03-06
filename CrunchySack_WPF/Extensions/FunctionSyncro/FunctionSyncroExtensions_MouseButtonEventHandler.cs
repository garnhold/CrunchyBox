﻿using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class FunctionSyncroExtensions_MouseButtonEventHandler
    {
        static public MouseButtonEventHandler GetMouseButtonEventHandler(this FunctionSyncro item, Predicate<MouseButtonEventArgs> predicate)
        {
            if (item.GetFunction().HasNoParameters())
            {
                return delegate(object sender, MouseButtonEventArgs e) {
                    if (predicate(e))
                        item.Execute();
                };
            }

            if (item.GetFunction().CanParametersHold<object, MouseButtonEventArgs>())
            {
                return delegate(object sender, MouseButtonEventArgs e) {
                    if (predicate(e))
                        item.Execute(new object[] { sender, e });
                };
            }

            if (item.GetFunction().CanParametersHold<MouseButtonEventArgs>())
            {
                return delegate(object sender, MouseButtonEventArgs e) {
                    if (predicate(e))
                        item.Execute(new object[] { e });
                };
            }

            throw new UnexpectedSignatureException(item.GetFunction().GetParameterTypes());
        }
        static public MouseButtonEventHandler GetMouseButtonEventHandler(this FunctionSyncro item)
        {
            return item.GetMouseButtonEventHandler(e => true);
        }
    }
}