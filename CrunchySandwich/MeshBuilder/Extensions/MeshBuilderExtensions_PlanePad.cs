using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class MeshBuilderExtensions_PlanePad
    {
        static public void AddPlanePad(this MeshBuilder item, IEnumerable<Vector2> vertex_loop, PlaneSpace plane_space, float depth)
        {
            Vector3 extrusion = plane_space.plane.normal * depth;

            ICollection<Vector2>  base_vertex_loop = vertex_loop
                .WindClockwise()
                .PrepareForMultipass();

            plane_space.InflateTriangles(base_vertex_loop.TesselateLoop())
                .Process(t => {
                    item.AddTriangle(t);
                    item.AddTriangle(t.GetShifted(extrusion).GetReversedWinding());
                });

            plane_space.InflatePoints(base_vertex_loop)
                .CloseLoop()
                .ProcessConnections(
                    (v1, v2) => item.AddQuad(v1, v1 + extrusion, v2 + extrusion, v2)
                );
        }
    }
}