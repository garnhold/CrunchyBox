using System;
using System.IO;
using System.Drawing;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class PointerEventArgsExtensions_Button
    {
        static public PointerUpdateKind GetPointerUpdateKind(this PointerEventArgs item)
        {
            return item.GetCurrentPoint(null).Properties.PointerUpdateKind;
        }
    }
}