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
    static public class RectFExtensions_Rect
    {
        static public Rect GetRect(this RectF item)
        {
            return new Rect((int)item.Left, (int)item.Top, (int)item.Right, (int)item.Bottom);
        }
    }
}