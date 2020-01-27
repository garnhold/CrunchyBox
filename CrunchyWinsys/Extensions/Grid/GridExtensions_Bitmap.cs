using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Crunchy.Winsys
{
    using Dough;
    using Salt;
    using Noodle;
    using Sauce;
    
    static public class GridExtensions_Bitmap
    {
        static public Bitmap CreateBitmap<T>(this IList2D<T> item, Operation<Color, T> operation)
        {
            Bitmap bitmap = new Bitmap(item.GetWidth(), item.GetHeight());

            item.ProcessWithIndexs((x, y, v) => bitmap.SetPixel(x, y, operation(v)));
            return bitmap;
        }
    }
}