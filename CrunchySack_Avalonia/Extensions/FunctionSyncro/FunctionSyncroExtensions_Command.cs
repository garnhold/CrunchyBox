using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;
using System.Windows.Input;

namespace Crunchy.Sack_Avalonia
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