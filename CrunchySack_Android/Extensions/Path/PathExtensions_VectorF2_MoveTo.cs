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
    
    static public class PathExtensions_VectorF2_MoveTo
    {
        static public void MoveTo(this Path item, VectorF2 point)
        {
            item.MoveTo(point.x, point.y);
        }
    }
}