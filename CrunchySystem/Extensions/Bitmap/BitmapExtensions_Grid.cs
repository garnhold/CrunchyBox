using System;
using System.Drawing;
using System.Drawing.Imaging;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySauce;

namespace CrunchySystem
{
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