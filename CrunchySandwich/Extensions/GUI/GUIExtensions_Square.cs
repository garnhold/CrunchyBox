using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class GUIExtensions
    {
        static public void DrawCenterRect(Vector2 center, Vector2 size)
        {
            GUI.DrawTexture(
                RectExtensions.CreateCenterRect(center, size),
                GetWhitePixelTexture()
            );
        }
        static public void DrawCenterSquare(Vector2 center, float size)
        {
            DrawCenterRect(center, new Vector2(size, size));
        }
    }
}