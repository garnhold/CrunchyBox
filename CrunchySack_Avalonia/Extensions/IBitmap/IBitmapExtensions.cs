using System;
using System.IO;
using System.Drawing;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    
    [Conversion]
    static public class IBitmapExtensions
    {
        [Conversion]
        static public IBitmap Create(System.Drawing.Image image)
        {
            return Transfer.StreamViaMemory(
                s => image.Save(s, System.Drawing.Imaging.ImageFormat.Png),
                s => Create(s)
            );
        }

        [Conversion]
        static public IBitmap Create(Stream stream)
        {
            return new Avalonia.Media.Imaging.Bitmap(stream);
        }
    }
}