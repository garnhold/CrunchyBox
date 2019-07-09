using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
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
    }
}