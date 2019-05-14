using System;
using System.Collections;
using System.Collections.Generic;

using Android;
using Android.App;
using Android.Views;
using Android.Content;
using Android.Graphics;
using Android.Content.Res;

using CrunchyDough;
using CrunchyBun;
using CrunchySack;

namespace CrunchySack_Android
{
    static public class PathExtensions_VectorF2_LineTo
    {
        static public void LineTo(this Path item, VectorF2 point)
        {
            item.LineTo(point.x, point.y);
        }

        static public void LineTo(this Path item, IEnumerable<VectorF2> points)
        {
            points.Process(p => item.LineTo(p));
        }
        static public void LineTo(this Path item, params VectorF2[] points)
        {
            item.LineTo((IEnumerable<VectorF2>)points);
        }
    }
}