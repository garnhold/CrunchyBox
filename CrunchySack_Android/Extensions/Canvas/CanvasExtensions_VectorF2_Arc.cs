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
    static public class CanvasExtensions_VectorF2_Arc
    {
        static public void DrawArc(this Canvas item, VectorF2 center, VectorF2 size, float angle1, float angle2, bool use_center, Paint paint)
        {
            item.DrawArc(RectFExtensions.CreateCenterRectF(center, size), angle1, angle2 - angle1, use_center, paint);
        }
    }
}