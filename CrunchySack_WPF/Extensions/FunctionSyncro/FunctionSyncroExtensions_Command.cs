using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Crunchy.Sack_WPF
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class FunctionSyncroExtensions_Command
    {
        static public ICommand GetCommand(this FunctionSyncro item)
        {
            if (item.GetFunction().HasNoParameters())
            {
                return new ProcessCommand(delegate(object obj) {
                    item.Execute();
                });
            }

            if (item.GetFunction().CanParametersHold<object>())
            {
                return new ProcessCommand(delegate(object obj) {
                    item.Execute(new object[] { obj });
                });
            }

            throw new UnexpectedSignatureException(item.GetFunction().GetParameterTypes());
        }
    }
}