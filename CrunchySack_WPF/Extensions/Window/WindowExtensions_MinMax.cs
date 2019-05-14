using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Windows;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySack;

namespace CrunchySack_WPF
{
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