using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class PlaneSpaceExtensions_Project
    {
        static public Vector2 ProjectPoint(this PlaneSpace item, Vector3 point)
        {
            return new Vector2(item.x.GetDot(point), item.y.GetDot(point));
        }
        static public IEnumerable<Vector2> ProjectPoints(this PlaneSpace item, IEnumerable<Vector3> points)
        {
            return points.Convert(p => item.ProjectPoint(p));
        }

        static public Vector2 ProjectVector(this PlaneSpace item, Vector3 vector)
        {
            return item.ProjectPoint(vector + item.origin);
        }
        static public IEnumerable<Vector2> ProjectVectors(this PlaneSpace item, IEnumerable<Vector3> vectors)
        {
            return vectors.Convert(v => item.ProjectVector(v));
        }

        static public LineSegment2 ProjectLineSegment(this PlaneSpace item, LineSegment3 line_segment)
        {
            return new LineSegment2(item.ProjectPoint(line_segment.v0), item.ProjectPoint(line_segment.v1));
        }
        static public IEnumerable<LineSegment2> ProjectLineSegments(this PlaneSpace item, IEnumerable<LineSegment3> line_segments)
        {
            return line_segments.Convert(l => item.ProjectLineSegment(l));
        }

        static public Triangle2 ProjectTriangle(this PlaneSpace item, Triangle3 triangle)
        {
            return new Triangle2(item.ProjectPoint(triangle.v0), item.ProjectPoint(triangle.v1), item.ProjectPoint(triangle.v2));
        }
        static public IEnumerable<Triangle2> ProjectTriangles(this PlaneSpace item, IEnumerable<Triangle3> triangles)
        {
            return triangles.Convert(t => item.ProjectTriangle(t));
        }
    }
}