using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class GUIExtensions
    {
        static public void DrawRect(Rect rect, Color color)
        {
            GUIExtensions.PushPopColor(color, delegate() {
                GUI.DrawTexture(
                    rect,
                    GetWhitePixelTexture()
                );
            });
        }

        static public void DrawOutlinedRect(Rect rect, Color primary, float weight, Color outline)
        {
            DrawRect(rect, outline);
            DrawRect(rect.GetShrunk(weight), primary);
        }
        static public void DrawOutlinedRect(Rect rect, Color primary, float weight)
        {
            DrawOutlinedRect(rect, primary, weight, primary.GetBrightened(0.7f));
        }
        static public void DrawOutlinedRect(Rect rect, Color primary)
        {
            DrawOutlinedRect(rect, primary, 1.0f);
        }
    }
}