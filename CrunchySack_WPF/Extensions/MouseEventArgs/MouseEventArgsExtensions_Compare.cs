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
    
    static public class MouseEventArgsExtensions_Compare
    {
        static public bool IsPressed(this MouseEventArgs item)
        {
            if (item.LeftButton == MouseButtonState.Pressed ||
                item.MiddleButton == MouseButtonState.Pressed ||
                item.RightButton == MouseButtonState.Pressed ||
                item.XButton1 == MouseButtonState.Pressed ||
                item.XButton2 == MouseButtonState.Pressed)
                return true;

            return false;
        }
    }
}