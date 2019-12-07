using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Android;
using Android.App;
using Android.Graphics;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Bun;
    using Sack;
    
    static public class CanvasExtensions_VectorF2_Bitmap
    {
        static public void DrawBitmap(this Canvas item, VectorF2 position, Bitmap bitmap)
        {
            item.DrawBitmap(bitmap, position.x, position.y, null);
        }

        static public void DrawBitmap(this Canvas item, RectF rect, Bitmap bitmap)
        {
            item.DrawBitmap(bitmap, bitmap.GetRect(), rect, null);
        }
        static public void DrawBitmap(this Canvas item, VectorF2 position, VectorF2 size, Bitmap bitmap)
        {
            item.DrawBitmap(RectFExtensions.CreateMinMaxRectF(position, position + size), bitmap);
        }
        static public void DrawCenterBitmap(this Canvas item, VectorF2 position, VectorF2 size, Bitmap bitmap)
        {
            item.DrawBitmap(RectFExtensions.CreateCenterRectF(position, size), bitmap);
        }
    }
}