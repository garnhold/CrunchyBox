using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public partial class GizmosExtensions
    {
        static public void DrawPath(IEnumerable<Vector3> path, float point_size = 0.0f)
        {
            path.ProcessConnections((v1, v2) => Gizmos.DrawLine(v1, v2));

            if (point_size > 0.0f)
                path.Process(v => Gizmos.DrawSphere(v, point_size));
        }
        static public void DrawPath(IEnumerable<Vector2> path, float point_size = 0.0f)
        {
            DrawPath(path.Convert(v => v.GetSpacar()), point_size);
        }
    }
}