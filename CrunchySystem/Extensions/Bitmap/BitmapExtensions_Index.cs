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
    static public class BitmapExtensions_Index
    {
        static public bool IsIndexValid(this Bitmap item, int x, int y)
        {
            if (item != null)
            {
                if (x >= 0 && x < item.Width)
                {
                    if (y >= 0 && y < item.Height)
                        return true;
                }
            }

            return false;
        }
    }
}