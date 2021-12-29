using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class GUIExtensions
    {
        static public void DrawPoint(Vector2 p1, float size, Color color)
        {
            DrawRect(p1.GetRect().GetEnlarged(size), color);
        }
    }
}