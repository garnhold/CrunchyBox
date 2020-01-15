using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class FunctionSyncroExtensions_MouseEventHandler
    {
        static public MouseEventHandler GetMouseEventHandler(this FunctionSyncro item, Predicate<MouseEventArgs> predicate)
        {
            if (item.GetFunction().HasNoParameters())
            {
                return delegate(object sender, MouseEventArgs e) {
                    if (predicate(e))
                        item.Execute();
                };
            }

            if (item.GetFunction().CanParametersHold<object, MouseEventArgs>())
            {
                return delegate(object sender, MouseEventArgs e) {
                    if (predicate(e))
                        item.Execute(new object[] { sender, e });
                };
            }

            if (item.GetFunction().CanParametersHold<MouseEventArgs>())
            {
                return delegate(object sender, MouseEventArgs e) {
                    if (predicate(e))
                        item.Execute(new object[] { e });
                };
            }

            throw new UnexpectedSignatureException(item.GetFunction().GetParameterTypes());
        }
        static public MouseEventHandler GetMouseEventHandler(this FunctionSyncro item)
        {
            return item.GetMouseEventHandler(e => true);
        }
    }
}