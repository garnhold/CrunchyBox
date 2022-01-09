using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public partial class GizmosExtensions
    {
        static public void DrawPoint(Vector3 center, float perceived_radius=5.0f)
        {
            Camera camera = Camera.current;

            if (camera.orthographic)
            {
                Gizmos.DrawSphere(center, camera.ConvertPixelsToOrthographicWorld(perceived_radius));
            }
            else
            {
                float distance = camera.GetSpacarDistanceBetween(center);

                Gizmos.DrawSphere(center, camera.ConvertPixelsToPerspectiveWorld(distance, perceived_radius));
            }
        }
    }
}