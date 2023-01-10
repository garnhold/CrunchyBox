using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class PlaneSpaceExtensions_Deflate
    {
        static public Vector2 DeflatePoint(this PlaneSpace item, Vector3 point)
        {
            return new Vector2(item.x.GetDot(point), item.y.GetDot(point));
        }
        static public IEnumerable<Vector2> DeflatePoints(this PlaneSpace item, IEnumerable<Vector3> points)
        {
            return points.Convert(p => item.DeflatePoint(p));
        }

        static public Vector2 DeflateVector(this PlaneSpace item, Vector3 vector)
        {
            return item.DeflatePoint(vector + item.origin);
        }
        static public IEnumerable<Vector2> DeflateVectors(this PlaneSpace item, IEnumerable<Vector3> vectors)
        {
            return vectors.Convert(v => item.DeflateVector(v));
        }

        static public LineSegment2 DeflateLineSegment(this PlaneSpace item, LineSegment3 line_segment)
        {
            return new LineSegment2(item.DeflatePoint(line_segment.v0), item.DeflatePoint(line_segment.v1));
        }
        static public IEnumerable<LineSegment2> DeflateLineSegments(this PlaneSpace item, IEnumerable<LineSegment3> line_segments)
        {
            return line_segments.Convert(l => item.DeflateLineSegment(l));
        }

        static public Triangle2 DeflateTriangle(this PlaneSpace item, Triangle3 triangle)
        {
            return new Triangle2(item.DeflatePoint(triangle.v0), item.DeflatePoint(triangle.v1), item.DeflatePoint(triangle.v2));
        }
        static public IEnumerable<Triangle2> DeflateTriangles(this PlaneSpace item, IEnumerable<Triangle3> triangles)
        {
            return triangles.Convert(t => item.DeflateTriangle(t));
        }
    }
}