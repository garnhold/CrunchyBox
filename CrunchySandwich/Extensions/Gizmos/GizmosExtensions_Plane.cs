using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public partial class GizmosExtensions
    {
        static public void DrawPlane(Plane plane, Vector3 position, float size)
        {
            position = plane.ProjectPoint(position);

            UseMatrix(
                Matrix4x4.TRS(position, Quaternion.LookRotation(plane.normal), Vector3.one),
                delegate() {
                    Gizmos.DrawCube(Vector3.zero, new Vector3(size, size, 0.035f));
                }
            );

            DrawVectorArrow(position, plane.normal, 0.3f);
        }
        static public void DrawPlane(Plane plane, Vector3 position)
        {
            DrawPlane(plane, position, 10.0f);
        }
        static public void DrawPlane(Plane plane)
        {
            DrawPlane(plane, Vector3.zero);
        }
    }
}