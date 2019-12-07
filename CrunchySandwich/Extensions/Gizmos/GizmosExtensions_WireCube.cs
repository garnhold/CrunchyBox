using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public partial class GizmosExtensions
    {
        static public void DrawWireCube(Vector3 center, Vector3 size)
        {
            Gizmos.DrawWireCube(center, size);
        }
        static public void DrawWireCube(Bounds bounds)
        {
            DrawWireCube(bounds.center, bounds.size);
        }
        static public void DrawWireCube(Rect bounds)
        {
            DrawWireCube(bounds.center, bounds.size);
        }
    }
}