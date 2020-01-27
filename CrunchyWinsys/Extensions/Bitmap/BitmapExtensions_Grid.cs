using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Crunchy.Winsys
{
    using Dough;
    using Salt;
    using Noodle;
    using Sauce;

    static public class BitmapExtensions_Grid
    {
        static public IList2D<T> ConvertToGrid<T>(this Bitmap item, Operation<T, Color> operation)
        {
            return new IList2DTransform<T>(item.Width, item.Height,
                (x, y) => operation(item.GetPixel(x, y))
            );
        }
    }
}