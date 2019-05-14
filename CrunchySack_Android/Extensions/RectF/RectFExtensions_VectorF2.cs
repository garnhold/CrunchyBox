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
    static public class RectFExtensions_VectorF2
    {
        static public VectorF2 GetLeftBottom(this RectF item)
        {
            return new VectorF2(item.Left, item.Bottom);
        }

        static public VectorF2 GetRightBottom(this RectF item)
        {
            return new VectorF2(item.Right, item.Bottom);
        }

        static public VectorF2 GetLeftTop(this RectF item)
        {
            return new VectorF2(item.Left, item.Top);
        }

        static public VectorF2 GetRightTop(this RectF item)
        {
            return new VectorF2(item.Right, item.Top);
        }

        static public VectorF2 GetCenter(this RectF item)
        {
            return new VectorF2(item.CenterX(), item.CenterY());
        }

        static public VectorF2 GetSize(this RectF item)
        {
            return new VectorF2(item.Width(), item.Height());
        }
    }
}