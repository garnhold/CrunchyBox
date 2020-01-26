using System;
using System.IO;

using Android;
using Android.App;
using Android.Graphics;

namespace Crunchy.Sack_Android
{
    using Dough;    using Sack;
    
    static public class BitmapExtensions_Size
    {
        static public VectorF2 GetSize(this Bitmap item)
        {
            return new VectorF2(item.Width, item.Height);
        }
    }
}