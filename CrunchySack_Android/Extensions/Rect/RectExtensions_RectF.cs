using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;
using Android.Content;
using Android.Graphics;
using Android.Content.Res;

namespace Crunchy.Sack_Android
{
    using Dough;    using Sack;
    
    static public class RectExtensions_RectF
    {
        static public RectF GetRectF(this Rect item)
        {
            return new RectF(item);
        }
    }
}