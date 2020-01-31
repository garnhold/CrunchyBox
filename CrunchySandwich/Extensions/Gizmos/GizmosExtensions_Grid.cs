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

        static public void DrawArearGrid(Vector2 minimum, Vector2 maximum, Vector2 cell_size, float y = 0.0f)
        {
            Vector3 minimum3 = minimum.GetArear(y);
            Vector3 maximum3 = maximum.GetArear(y);

            Floats.Range(minimum.y, maximum.y, cell_size.y, true)
                .Process(z => Gizmos.DrawLine(minimum3.GetWithZ(z), maximum3.GetWithZ(z)));

            Floats.Range(minimum.x, maximum.x, cell_size.x, true)
                .Process(x => Gizmos.DrawLine(minimum3.GetWithX(x), maximum3.GetWithX(x)));
        }
        static public void DrawArearGrid(Rect rect, Vector2 cell_size, float y = 0.0f)
        {
            DrawArearGrid(rect.min, rect.max, cell_size, y);
        }
    }
}