using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Triangle3Extensions_Edge
    {
        static public LineSegment3 GetEdge01(this Triangle3 item)
        {
            return new LineSegment3(item.v0, item.v1);
        }

        static public LineSegment3 GetEdge12(this Triangle3 item)
        {
            return new LineSegment3(item.v1, item.v2);
        }

        static public LineSegment3 GetEdge20(this Triangle3 item)
        {
            return new LineSegment3(item.v2, item.v0);
        }

        static public IEnumerable<LineSegment3> GetEdges(this Triangle3 item)
        {
            return item.GetPoints().CloseLoop().Connect();
        }
    }
}