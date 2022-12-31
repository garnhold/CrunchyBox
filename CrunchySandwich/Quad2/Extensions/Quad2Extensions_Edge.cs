using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Quad2Extensions_Edge
    {
        static public LineSegment2 GetEdge01(this Quad2 item)
        {
            return new LineSegment2(item.v0, item.v1);
        }

        static public LineSegment2 GetEdge12(this Quad2 item)
        {
            return new LineSegment2(item.v1, item.v2);
        }

        static public LineSegment2 GetEdge23(this Quad2 item)
        {
            return new LineSegment2(item.v2, item.v3);
        }

        static public LineSegment2 GetEdge30(this Quad2 item)
        {
            return new LineSegment2(item.v3, item.v0);
        }

        static public IEnumerable<LineSegment2> GetEdges(this Quad2 item)
        {
            return item.GetPoints().CloseLoop().Connect();
        }
    }
}