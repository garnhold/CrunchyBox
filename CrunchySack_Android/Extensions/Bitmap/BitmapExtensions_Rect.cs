using System;
using System.IO;

using Android;
using Android.App;
using Android.Graphics;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Bun;
    using Sack;
    
    static public class BitmapExtensions_Rect
    {
        static public Rect GetRect(this Bitmap item)
        {
            return new Rect(0, 0, item.Width, item.Height);
        }
    }
}