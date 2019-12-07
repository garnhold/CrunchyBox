using System;
using System.Collections;
using System.Collections.Generic;

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
    
    static public class PathExtensions_VectorF2_RLineTo
    {
        static public void RLineTo(this Path item, VectorF2 point)
        {
            item.RLineTo(point.x, point.y);
        }

        static public void RLineTo(this Path item, IEnumerable<VectorF2> points)
        {
            points.Process(p => item.RLineTo(p));
        }
        static public void RLineTo(this Path item, params VectorF2[] points)
        {
            item.RLineTo((IEnumerable<VectorF2>)points);
        }
    }
}