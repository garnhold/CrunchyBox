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
    using Dough;
    using Sack;
    
    static public class PaintExtensions
    {
        static public Paint Create(Color color, Paint.Style style, PaintFlags paint_flags)
        {
            Paint paint = new Paint(paint_flags);

            paint.Color = color;
            paint.SetStyle(style);

            return paint;
        }

        static public Paint CreateNice(Color color, Paint.Style style)
        {
            return Create(color, style, PaintFlags.AntiAlias);
        }

        static public Paint CreateNiceText(Color color)
        {
            Paint paint = CreateNice(color, Paint.Style.Stroke);

            return paint;
        }

        static public Paint CreateNiceStroke(Color color, float stroke_width)
        {
            Paint paint = CreateNice(color, Paint.Style.Stroke);

            paint.StrokeWidth = stroke_width;
            paint.StrokeCap = Paint.Cap.Round;
            paint.StrokeJoin = Paint.Join.Round;
            return paint;
        }

        static public Paint CreateNiceFill(Color color)
        {
            Paint paint = CreateNice(color, Paint.Style.Fill);

            return paint;
        }
    }
}