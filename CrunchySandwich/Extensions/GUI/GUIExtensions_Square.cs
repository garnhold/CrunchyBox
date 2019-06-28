using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public partial class GUIExtensions
    {
        static public void DrawRect(Vector2 center, Vector2 size)
        {
            GUI.DrawTexture(
                RectExtensions.CreateCenterRect(center, size),
                GetWhitePixelTexture()
            );
        }
        static public void DrawSquare(Vector2 center, float size)
        {
            DrawRect(center, new Vector2(size, size));
        }
    }
}