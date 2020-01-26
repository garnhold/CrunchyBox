using System;
using System.IO;

using Android;
using Android.App;
using Android.Graphics;

namespace Crunchy.Sack_Android
{
    using Dough;    using Sack;
    
    static public class BitmapExtensions_RectF
    {
        static public RectF GetRectF(this Bitmap item)
        {
            return new RectF(0.0f, 0.0f, item.Width, item.Height);
        }
    }
}