﻿using System;
using System.IO;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySack;

namespace CrunchySack_WPF
{
    static public class DependencyObjectExtensions_Window
    {
        static public Window GetWindow(this DependencyObject item)
        {
            return Window.GetWindow(item);
        }
    }
}