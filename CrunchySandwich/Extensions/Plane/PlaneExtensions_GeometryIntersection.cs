using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class PlaneExtensions_GeometryIntersection
    {
        static public IEnumerable<Vector3> GetTriangleIntersection(this Plane item, Triangle3 triangle)
        {
            if (triangle.IsDegenerate() == false)
            {
                if (item.FullyContains(triangle))
                    return triangle.GetPoints();

                Plane plane = triangle.GetPlane();

                if (plane.normal != Vector3.zero)
                {
                    PlaneSpace plane_space = plane.GetPlaneSpace();

                    ConvexPolygon triangle_polygon = new ConvexPolygon(
                        plane_space.ProjectPoints(triangle.GetPoints())
                    );

                    Plane2 plane_polygon;
                    if (plane_space.IsIntersecting(item, out plane_polygon))
                    {
                        return plane_space.InflatePoints(
                            triangle_polygon.GetIntersection(plane_polygon).GetVertexs()
                        );
                    }
                }
            }

            return Empty.IEnumerable<Vector3>();
        }
    }
}