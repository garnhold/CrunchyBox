using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public partial class GizmosExtensions
    {
        static public void DrawPlanarGrid(Vector2 minimum, Vector2 maximum, Vector2 cell_size)
        {
            Floats.Range(minimum.y, maximum.y, cell_size.y, true)
                .Process(y => Gizmos.DrawLine(minimum.GetWithY(y), maximum.GetWithY(y)));

            Floats.Range(minimum.x, maximum.x, cell_size.x, true)
                .Process(x => Gizmos.DrawLine(minimum.GetWithX(x), maximum.GetWithX(x)));
        }
        static public void DrawPlanarGrid(Rect rect, Vector2 cell_size)
        {
            DrawPlanarGrid(rect.min, rect.max, cell_size);
        }
    }
}