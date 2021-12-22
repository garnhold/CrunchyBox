using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public partial class GizmosExtensions
    {
        static public void DrawDegreeSectorOutline(float start_angle, float end_angle, Vector3 center, float radius)
        {
            DrawLoop(
                Floats.Line(start_angle, end_angle, 32, true)
                    .Convert(a => center + Vector2Extensions.CreateDirectionFromDegrees(a).GetSpacar() * radius)
                    .AppendIf(start_angle.GetDegreeAngleDistance(end_angle) <= 0.0f, center)
            );
        }

        static public void DrawDegreeSector(float start_angle, float end_angle, Vector3 center, float radius)
        {
            GizmosExtensions.UseMatrix(
                Matrix4x4.TRS(
                    center,
                    Quaternion.identity,
                    new Vector3(radius, radius, radius) * 2.0f
                ),
                () => Gizmos.DrawMesh(MeshExtensions.CreateDegreeSector(start_angle, end_angle, 32))
            );
        }
    }
}