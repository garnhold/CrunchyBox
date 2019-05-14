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