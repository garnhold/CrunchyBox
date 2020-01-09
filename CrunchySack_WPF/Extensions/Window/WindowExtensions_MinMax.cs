using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Windows;

namespace Crunchy.Sack.WPF
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