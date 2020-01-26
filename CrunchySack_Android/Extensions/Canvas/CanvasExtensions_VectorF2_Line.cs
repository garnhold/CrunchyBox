using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Android;
using Android.App;
using Android.Graphics;

namespace Crunchy.Sack_Android
{
    using Dough;    using Sack;
    
    static public class CanvasExtensions_VectorF2_Line
    {
        static public void DrawLine(this Canvas item, VectorF2 point1, VectorF2 point2, Paint paint)
        {
            item.DrawLine(point1.x, point1.y, point2.x, point2.y, paint);
        }

        static public void DrawContinousLines(this Canvas item, IEnumerable<VectorF2> points, Paint paint)
        {
            points.ProcessConnections((p1, p2) => item.DrawLine(p1, p2, paint));
        }

        static public void DrawContinousLineLoop(this Canvas item, IEnumerable<VectorF2> points, Paint paint)
        {
            item.DrawContinousLines(points.CloseLoop(), paint);
        }
    }
}