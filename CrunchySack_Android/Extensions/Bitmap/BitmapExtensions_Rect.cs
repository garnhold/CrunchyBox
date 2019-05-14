using System;
using System.IO;

using Android;
using Android.App;
using Android.Graphics;

using CrunchyDough;
using CrunchyBun;
using CrunchySack;

namespace CrunchySack_Android
{
    static public class BitmapExtensions_Rect
    {
        static public Rect GetRect(this Bitmap item)
        {
            return new Rect(0, 0, item.Width, item.Height);
        }
    }
}