using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public partial class GizmosExtensions
    {
        static public void DrawArrow(Vector3 from, Vector3 to, float size)
        {
            float distance;
            Vector3 direction = from.GetDirection(to, out distance);

            if (distance > 0.0f)
            {
                Gizmos.DrawLine(from, to - direction * size);

                UseMatrix(Matrix4x4.TRS(to, Quaternion.LookRotation(-direction), Vector3.one), delegate() {
                    Gizmos.DrawFrustum(Vector3.zero, 45.0f, size, 0.0f, 1.0f);
                });
            }
            else
            {
                Gizmos.DrawSphere(from, size * 0.25f);
            }
        }
        static public void DrawArrow(Vector3 from, Vector3 to)
        {
            DrawArrow(from, to, 0.3f);
        }

        static public void DrawVectorArrow(Vector3 origin, Vector3 vector, float size)
        {
            DrawArrow(origin, origin + vector, size);
        }
        static public void DrawVectorArrow(Vector3 origin, Vector3 vector)
        {
            DrawVectorArrow(origin, vector, 0.3f);
        }
    }
}