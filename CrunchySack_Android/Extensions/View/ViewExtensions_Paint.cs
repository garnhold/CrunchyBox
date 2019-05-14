using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;
using Android.Graphics;
using Android.Content;
using Android.Content.Res;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_Android
{
    static public class ViewExtensions_Paint
    {
        static public Paint CreateThemeColorTextPaint(this View item, int attribute_id)
        {
            return item.Context.CreateThemeColorTextPaint(attribute_id);
        }
        static public Paint CreateThemeColorStrokePaint(this View item, int attribute_id, float stroke_width)
        {
            return item.Context.CreateThemeColorStrokePaint(attribute_id, stroke_width);
        }
        static public Paint CreateThemeColorFillPaint(this View item, int attribute_id)
        {
            return item.Context.CreateThemeColorFillPaint(attribute_id);
        }

        static public Paint CreateThemeColorAccentTextPaint(this View item)
        {
            return item.Context.CreateThemeColorAccentTextPaint();
        }
        static public Paint CreateThemeColorAccentStrokePaint(this View item, float stroke_width)
        {
            return item.Context.CreateThemeColorAccentStrokePaint(stroke_width);
        }
        static public Paint CreateThemeColorAccentFillPaint(this View item)
        {
            return item.Context.CreateThemeColorAccentFillPaint();
        }

        static public Paint CreateThemeColorPrimaryTextPaint(this View item)
        {
            return item.Context.CreateThemeColorPrimaryTextPaint();
        }
        static public Paint CreateThemeColorPrimaryStrokePaint(this View item, float stroke_width)
        {
            return item.Context.CreateThemeColorPrimaryStrokePaint(stroke_width);
        }
        static public Paint CreateThemeColorPrimaryFillPaint(this View item)
        {
            return item.Context.CreateThemeColorPrimaryFillPaint();
        }

        static public Paint CreateThemeColorPrimaryDarkTextPaint(this View item)
        {
            return item.Context.CreateThemeColorPrimaryDarkTextPaint();
        }
        static public Paint CreateThemeColorPrimaryDarkStrokePaint(this View item, float stroke_width)
        {
            return item.Context.CreateThemeColorPrimaryDarkStrokePaint(stroke_width);
        }
        static public Paint CreateThemeColorPrimaryDarkFillPaint(this View item)
        {
            return item.Context.CreateThemeColorPrimaryDarkFillPaint();
        }
    }
}