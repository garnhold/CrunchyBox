using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public partial class GizmosExtensions
    {
        static public void DrawCircleOutline(Vector3 center, float radius)
        {
            DrawLoop(
                Floats.Line(0.0f, 360.0f, 32, true)
                    .Convert(a => center + Vector2Extensions.CreateDirectionFromDegrees(a).GetSpacar() * radius)
            );
        }

        static public void DrawCircle(Vector3 center, float radius)
        {
            GizmosExtensions.UseMatrix(
                Matrix4x4.TRS(
                    center,
                    Quaternion.identity,
                    new Vector3(radius, radius, radius) * 2.0f
                ),
                () => Gizmos.DrawMesh(MeshExtensions.CreateCircle(32))
            );
        }
    }
}