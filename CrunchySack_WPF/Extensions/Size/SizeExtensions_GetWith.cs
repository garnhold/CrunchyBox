using System;
using System.IO;

using System.Windows;

namespace Crunchy.Sack.WPF
{
    using Dough;
    using Sack;
    
    static public class SizeExtensions_GetWith
    {
        static public Size GetWithWidth(this Size item, double width)
        {
            return new Size(width, item.Height);
        }

        static public Size GetWithHeight(this Size item, double height)
        {
            return new Size(item.Width, height);
        }
    }
}