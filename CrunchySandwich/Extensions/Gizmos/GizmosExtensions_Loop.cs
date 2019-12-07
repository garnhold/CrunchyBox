using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public partial class GizmosExtensions
    {
        static public void DrawLoop(IEnumerable<Vector3> loop, float point_size = 0.0f)
        {
            DrawPath(loop.CloseLoop(), point_size);
        }
        static public void DrawLoop(IEnumerable<Vector2> loop, float point_size = 0.0f)
        {
            DrawLoop(loop.Convert(v => v.GetSpacar()), point_size);
        }
    }
}