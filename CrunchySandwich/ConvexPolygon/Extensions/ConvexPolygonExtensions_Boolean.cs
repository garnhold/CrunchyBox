using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class ConvexPolygonExtensions_Boolean
    {
        static public ConvexPolygon GetIntersection(this ConvexPolygon item, Plane2 plane)
        {
            ConvexPolygon intersection = new ConvexPolygon();

            intersection.AddVertexs(item.GetVertexs().Narrow(v => plane.IsInside(v)));

            Vector2 point;
            foreach (Face face in item.GetFaces())
            {
                if (face.IsIntersecting(plane, out point))
                    intersection.AddVertex(point);
            }

            return intersection;
        }

        static public ConvexPolygon GetIntersection(this ConvexPolygon item, ConvexPolygon other)
        {
            ConvexPolygon intersection = new ConvexPolygon();

            intersection.AddVertexs(item.GetVertexs().Narrow(v => other.IsPointWithin(v)));
            intersection.AddVertexs(other.GetVertexs().Narrow(v => item.IsPointWithin(v)));
            
            Vector2 point;
            foreach (Face face1 in item.GetFaces())
            {
                foreach (Face face2 in other.GetFaces())
                {
                    if (face1.IsIntersecting(face2, out point))
                        intersection.AddVertex(point);
                }
            }
            
            return intersection;
        }
    }
}