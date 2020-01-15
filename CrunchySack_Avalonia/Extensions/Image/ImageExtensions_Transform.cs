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
    using Winsys;
    
    static public class ImageExtensions_Transform
    {
        static public System.Drawing.PointF TransformElementPointToImagePointF(this Avalonia.Controls.Image item, System.Windows.Point point)
        {
            double x_factor;
            double y_factor;
            BitmapSource bitmap_source;

            if (item.Source.Convert<BitmapSource>(out bitmap_source))
            {
                x_factor = bitmap_source.PixelWidth / item.ActualWidth;
                y_factor = bitmap_source.PixelHeight / item.ActualHeight;
            }
            else
            {
                x_factor = item.Source.Width / item.ActualWidth;
                y_factor = item.Source.Height / item.ActualHeight;
            }

            return new System.Drawing.PointF(
                (float)(point.X * x_factor),
                (float)(point.Y * y_factor)
            );
        }
        static public System.Drawing.Point TransformElementPointToImagePoint(this System.Windows.Controls.Image item, System.Windows.Point point)
        {
            return item.TransformElementPointToImagePointF(point).GetDrawingPoint();
        }
    }
}