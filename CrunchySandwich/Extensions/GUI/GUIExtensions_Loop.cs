using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public partial class GUIExtensions
    {
        static public void DrawLoop(IEnumerable<Vector2> loop, float line_thickness = 1.0f, float point_size = 0.0f)
        {
            DrawPath(loop.CloseLoop(), line_thickness, point_size);
        }
    }
}