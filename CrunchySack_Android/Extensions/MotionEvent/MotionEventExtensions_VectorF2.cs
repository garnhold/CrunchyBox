using System;
using System.IO;

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
    static public class MotionEventExtensions_VectorF2
    {
        static public VectorF2 GetPoint(this MotionEvent item)
        {
            return new VectorF2(item.GetX(), item.GetY());
        }
    }
}