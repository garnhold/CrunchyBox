using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public partial class GUIExtensions
    {
        static public void DrawPath(IEnumerable<Vector2> path, float line_thickness = 1.0f, float point_size = 0.0f)
        {
            path.ProcessConnections((v1, v2) => DrawLine(v1, v2, line_thickness));

            if (point_size > 0.0f)
                path.Process(v => DrawCenterSquare(v, point_size));
        }
    }
}