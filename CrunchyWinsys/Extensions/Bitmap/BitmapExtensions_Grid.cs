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
        static public IList2D<T> CreateGrid<T>(this Bitmap item, Operation<T, Color> operation)
        {
            return new List2D_List<T>(item.Width, item.Height, delegate(int x, int y) {
                return operation(item.GetPixel(x, y));
            });
        }
    }
}