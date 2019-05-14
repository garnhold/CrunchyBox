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

        static public Edge2 ProjectEdge(this PlaneSpace item, Edge3 edge)
        {
            return new Edge2(item.ProjectPoint(edge.v0), item.ProjectPoint(edge.v1));
        }
        static public IEnumerable<Edge2> ProjectEdges(this PlaneSpace item, IEnumerable<Edge3> edges)
        {
            return edges.Convert(e => item.ProjectEdge(e));
        }
    }
}