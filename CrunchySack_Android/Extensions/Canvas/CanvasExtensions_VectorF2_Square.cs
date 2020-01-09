using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Android;
using Android.App;
using Android.Graphics;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Bun;
    using Sack;
    
    static public class CanvasExtensions_VectorF2_Square
    {
        static public void DrawCenterSquare(this Canvas item, VectorF2 center, float size, Paint paint)
        {
            item.DrawCenterRect(center, new VectorF2(size), paint);
        }

        static public void DrawCenterRoundSquare(this Canvas item, VectorF2 center, float size, float radius, Paint paint)
        {
            item.DrawCenterRoundRect(center, new VectorF2(size), radius, paint);
        }
    }
}