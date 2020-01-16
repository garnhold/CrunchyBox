using System;
using System.IO;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    using Winsys;
    
    static public class ImageExtensions_Transform
    {
        static public Point TransformElementPointToImagePoint(this Avalonia.Controls.Image item, System.Windows.Point point)
        {
            double x_factor = item.Source.PixelSize.Width / item.Width;
            double y_factor = item.Source.PixelSize.Height / item.Height;

            return new Point(
                (float)(point.X * x_factor),
                (float)(point.Y * y_factor)
            );
        }
    }
}