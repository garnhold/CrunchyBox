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
    static public class BitmapExtensions_Size
    {
        static public VectorF2 GetSize(this Bitmap item)
        {
            return new VectorF2(item.Width, item.Height);
        }
    }
}