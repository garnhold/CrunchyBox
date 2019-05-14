using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class BoundsExtensions_GeometryIntersection
    {
        static public IEnumerable<Vector3> GetPlaneIntersection(this Bounds item, Plane plane)
        {
            Vector3 point;

            foreach (RayLine ray_line in item.GetEdges().Convert(p => new RayLine(p.item1, p.item2)))
            {
                if(plane.IntersectRayLine(ray_line, out point))
                    yield return point;
            }
        }

        static public IEnumerable<Vector3> GetTriangleIntersection(this Bounds item, Triangle3 triangle)
        {
            if (triangle.IsDegenerate() == false)
            {
                Plane plane = triangle.GetPlane();

                if (plane.normal != Vector3.zero)
                {
                    if (item.FullyContains(triangle))
                        return triangle.GetPoints();

                    PlaneSpace plane_space = plane.GetPlaneSpace();

                    ConvexPolygon plane_polygon = new ConvexPolygon(
                        plane_space.ProjectPoints(item.GetPlaneIntersection(plane))
                    );

                    ConvexPolygon triangle_polygon = new ConvexPolygon(
                        plane_space.ProjectPoints(triangle.GetPoints())
                    );

                    return plane_space.InflatePoints(
                        plane_polygon.GetIntersection(triangle_polygon).GetVertexs()
                    ).Narrow(p => item.Contains(p));
                }
            }

            return Empty.IEnumerable<Vector3>();
        }
    }
}