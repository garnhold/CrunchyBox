﻿using System;
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
    static public class PathExtensions_VectorF2_Loop
    {
        static public void Loop(this Path item, IEnumerable<VectorF2> points)
        {
            item.MoveTo(points.GetFirst());
            item.LineTo(points.Offset(1));
            item.Close();
        }
    }
}