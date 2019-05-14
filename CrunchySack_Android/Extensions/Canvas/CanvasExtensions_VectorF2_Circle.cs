using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Android;
using Android.App;
using Android.Graphics;

using CrunchyDough;
using CrunchyBun;
using CrunchySack;

namespace CrunchySack_Android
{
    static public class CanvasExtensions_VectorF2_Circle
    {
        static public void DrawCircle(this Canvas item, VectorF2 center, float radius, Paint paint)
        {
            item.DrawCircle(center.x, center.y, radius, paint);
        }

        static public void DrawOval(this Canvas item, VectorF2 center, VectorF2 size, Paint paint)
        {
            item.DrawOval(RectFExtensions.CreateCenterRectF(center, size), paint);
        }
    }
}