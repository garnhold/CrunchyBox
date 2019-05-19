using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class PlaneSpaceExtensions_Inflate
    {
        static public Vector3 InflatePoint(this PlaneSpace item, Vector2 point)
        {
            return point.x * item.x + point.y * item.y + item.origin;
        }
        static public IEnumerable<Vector3> InflatePoints(this PlaneSpace item, IEnumerable<Vector2> points)
        {
            return points.Convert(p => item.InflatePoint(p));
        }

        static public Vector3 InflateVector(this PlaneSpace item, Vector2 vector)
        {
            return item.InflatePoint(vector) - item.origin;
        }
        static public IEnumerable<Vector3> InflateVectors(this PlaneSpace item, IEnumerable<Vector2> vectors)
        {
            return vectors.Convert(v => item.InflateVector(v));
        }

        static public Triangle3 InflateTriangle(this PlaneSpace item, Triangle2 triangle)
        {
            return new Triangle3(
                item.InflatePoint(triangle.v0),
                item.InflatePoint(triangle.v1),
                item.InflatePoint(triangle.v2)
            );
        }
        static public IEnumerable<Triangle3> InflateTriangles(this PlaneSpace item, IEnumerable<Triangle2> triangles)
        {
            return triangles.Convert(t => item.InflateTriangle(t));
        }

        static public Triangle3 InflateTriangle(this PlaneSpace item, PolygonTriangle triangle)
        {
            return item.InflateTriangle(triangle.triangle);
        }
        static public IEnumerable<Triangle3> InflateTriangles(this PlaneSpace item, IEnumerable<PolygonTriangle> triangles)
        {
            return triangles.Convert(t => item.InflateTriangle(t));
        }
    }
}