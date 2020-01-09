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
    using Bun;
    using Sack;
    
    static public class PaintExtensions_Text
    {
        private const float FIT_TEXT_TEST_SIZE = 1024.0f;

        static public void GetTextBounds(this Paint item, string text, Rect bounds)
        {
            if (text != null)
                item.GetTextBounds(text, 0, text.Length, bounds);
            else
                bounds.SetEmpty();
        }
        static public Rect GetTextBounds(this Paint item, string text)
        {
            Rect bounds = new Rect();

            item.GetTextBounds(text, bounds);
            return bounds;
        }

        static public void GetTextBounds(this Paint item, string text, float size, Rect bounds)
        {
            float old_size = item.TextSize;

            item.TextSize = size;
                item.GetTextBounds(text, bounds);
            item.TextSize = old_size;
        }
        static public Rect GetTextBounds(this Paint item, string text, float size)
        {
            Rect bounds = new Rect();

            item.GetTextBounds(text, size, bounds);
            return bounds;
        }

        static public int GetTextBoundsWidth(this Paint item, string text)
        {
            return item.GetTextBounds(text).Width();
        }

        static public int GetTextBoundsHeight(this Paint item, string text)
        {
            return item.GetTextBounds(text).Height();
        }

        static public void FitText(this Paint item, string text, Rect target_bounds)
        {
            Rect current_bounds = item.GetTextBounds(text, FIT_TEXT_TEST_SIZE);

            float current_width = current_bounds.Width();
            float current_height = current_bounds.Height();

            if (current_width != 0.0f && current_height != 0.0f)
            {
                float width_ratio = target_bounds.Width() / current_width;
                float height_ratio = target_bounds.Height() / current_height;

                item.TextSize = FIT_TEXT_TEST_SIZE * width_ratio.Min(height_ratio);
            }
        }
    }
}