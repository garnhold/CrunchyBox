using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;
using Android.Content;
using Android.Graphics;
using Android.Content.Res;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Bun;
    using Sack;
    
    static public class MotionEventExtensions_VectorF2
    {
        static public VectorF2 GetPoint(this MotionEvent item)
        {
            return new VectorF2(item.GetX(), item.GetY());
        }
    }
}