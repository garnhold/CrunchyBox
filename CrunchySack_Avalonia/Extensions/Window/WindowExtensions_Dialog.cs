using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Threading.Tasks;

using Avalonia;
using Avalonia.Controls;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;

    static public class WindowExtensions_Dialog
    {
        static public void DoDialog<T>(this Window item, Process<T> process)
        {
            item.ShowDialog<T>(AvaloniaEngine.GetMainWindow())
                .ContinueWith(t => t.Result.IfNotNull(r => process(r)));
        }

        static public void OkClose(this Window item)
        {
            item.Close(true);
        }
        static public void CancelClose(this Window item)
        {
            item.Close(false);
        }
    }
}