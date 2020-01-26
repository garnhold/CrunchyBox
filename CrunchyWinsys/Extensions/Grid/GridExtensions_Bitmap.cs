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
        static public Bitmap CreateBitmap<T>(this Grid<T> item, Operation<Color, T> operation)
        {
            Bitmap bitmap = new Bitmap(item.GetWidth(), item.GetHeight());

            item.Process(c => bitmap.SetPixel(c.GetX(), c.GetY(), operation(c.GetData())));
            return bitmap;
        }
    }
}