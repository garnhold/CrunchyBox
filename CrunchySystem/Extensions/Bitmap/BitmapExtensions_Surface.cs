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
    static public class BitmapExtensions_Surface
    {
        static public Surface<Color> GetSurface(this Bitmap item)
        {
            return new Surface_Bitmap(item);
        }
    }
}