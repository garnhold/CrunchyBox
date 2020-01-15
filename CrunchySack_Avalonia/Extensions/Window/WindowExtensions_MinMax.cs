using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Avalonia;
using Avalonia.Controls;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class WindowExtensions_MinMax
    {
        static public void Minimize(this Window item)
        {
            item.WindowState = WindowState.Minimized;
        }

        static public void Maximize(this Window item)
        {
            item.WindowState = WindowState.Maximized;
        }
    }
}