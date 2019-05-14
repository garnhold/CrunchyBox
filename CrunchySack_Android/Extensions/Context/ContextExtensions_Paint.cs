using System;
using System.IO;

using Android;
using Android.App;
using Android.Graphics;
using Android.Content;
using Android.Content.Res;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_Android
{
    static public class ContextExtensions_Paint
    {
        static public Paint CreateThemeColorTextPaint(this Context item, int attribute_id)
        {
            return PaintExtensions.CreateNiceText(item.GetThemeColor(attribute_id));
        }
        static public Paint CreateThemeColorStrokePaint(this Context item, int attribute_id, float stroke_width)
        {
            return PaintExtensions.CreateNiceStroke(item.GetThemeColor(attribute_id), stroke_width);
        }
        static public Paint CreateThemeColorFillPaint(this Context item, int attribute_id)
        {
            return PaintExtensions.CreateNiceFill(item.GetThemeColor(attribute_id));
        }

        static public Paint CreateThemeColorAccentTextPaint(this Context item)
        {
            return PaintExtensions.CreateNiceText(item.GetThemeColorAccent());
        }
        static public Paint CreateThemeColorAccentStrokePaint(this Context item, float stroke_width)
        {
            return PaintExtensions.CreateNiceStroke(item.GetThemeColorAccent(), stroke_width);
        }
        static public Paint CreateThemeColorAccentFillPaint(this Context item)
        {
            return PaintExtensions.CreateNiceFill(item.GetThemeColorAccent());
        }

        static public Paint CreateThemeColorPrimaryTextPaint(this Context item)
        {
            return PaintExtensions.CreateNiceText(item.GetThemeColorPrimary());
        }
        static public Paint CreateThemeColorPrimaryStrokePaint(this Context item, float stroke_width)
        {
            return PaintExtensions.CreateNiceStroke(item.GetThemeColorPrimary(), stroke_width);
        }
        static public Paint CreateThemeColorPrimaryFillPaint(this Context item)
        {
            return PaintExtensions.CreateNiceFill(item.GetThemeColorPrimary());
        }

        static public Paint CreateThemeColorPrimaryDarkTextPaint(this Context item)
        {
            return PaintExtensions.CreateNiceText(item.GetThemeColorPrimaryDark());
        }
        static public Paint CreateThemeColorPrimaryDarkStrokePaint(this Context item, float stroke_width)
        {
            return PaintExtensions.CreateNiceStroke(item.GetThemeColorPrimaryDark(), stroke_width);
        }
        static public Paint CreateThemeColorPrimaryDarkFillPaint(this Context item)
        {
            return PaintExtensions.CreateNiceFill(item.GetThemeColorPrimaryDark());
        }
    }
}