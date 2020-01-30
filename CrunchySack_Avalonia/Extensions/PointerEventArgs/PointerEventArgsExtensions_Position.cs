using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.VisualTree;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    
    static public class PointerEventArgsExtensions_Position
    {
        static public Point GetPositionPercent(this PointerEventArgs item, IVisual parent)
        {
            return item.GetPosition(parent)
                .GetComponentDivide(parent.Bounds.Size.Width, parent.Bounds.Size.Height);
        }
    }
}