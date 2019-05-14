using System;
using System.IO;

using System.Windows;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_WPF
{
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