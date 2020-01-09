using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Crunchy.Winsys
{
    using Dough;
    using Salt;
    using Noodle;
    using Bun;
    using Sauce;
    
    static public class BitmapExtensions_Grid
    {
        static public Grid<T> CreateGrid<T>(this Bitmap item, Operation<T, Color> operation)
        {
            return new Grid<T>(item.Width, item.Height, delegate(int x, int y) {
                return operation(item.GetPixel(x, y));
            });
        }
    }
}