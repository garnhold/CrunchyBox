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
    static public class CanvasExtensions_VectorF2_Rect
    {
        static public void DrawRectWithPoints(this Canvas item, VectorF2 point1, VectorF2 point2, Paint paint)
        {
            item.DrawRect(RectFExtensions.CreateMinMaxRectF(point1, point2), paint);
        }
        static public void DrawRectWithPointAndSize(this Canvas item, VectorF2 point1, VectorF2 size, Paint paint)
        {
            item.DrawRectWithPoints(point1, point1 + size, paint);
        }

        static public void DrawCenterRect(this Canvas item, VectorF2 center, VectorF2 size, Paint paint)
        {
            item.DrawRect(RectFExtensions.CreateCenterRectF(center, size), paint);
        }

        static public void DrawRoundRectWithPoints(this Canvas item, VectorF2 point1, VectorF2 point2, float radius, Paint paint)
        {
            item.DrawRoundRect(RectFExtensions.CreateMinMaxRectF(point1, point2), radius, radius, paint);
        }
        static public void DrawRoundRectWithPointAndSize(this Canvas item, VectorF2 point1, VectorF2 size, float radius, Paint paint)
        {
            item.DrawRoundRectWithPoints(point1, point1 + size, radius, paint);
        }

        static public void DrawCenterRoundRect(this Canvas item, VectorF2 center, VectorF2 size, float radius, Paint paint)
        {
            item.DrawRoundRect(RectFExtensions.CreateCenterRectF(center, size), radius, radius, paint);
        }
    }
}