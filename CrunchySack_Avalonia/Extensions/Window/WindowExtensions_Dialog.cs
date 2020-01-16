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
        static public bool ShowDialog(this Window item)
        {
            Task<bool> task = item.ShowDialog<bool>(AvaloniaEngine.GetMainWindow());

            task.Wait();
            return task.Result;
        }
    }
}