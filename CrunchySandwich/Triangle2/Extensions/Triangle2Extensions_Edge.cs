using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Triangle2Extensions_Edge
    {
        static public Edge2 GetEdge01(this Triangle2 item)
        {
            return new Edge2(item.v0, item.v1);
        }

        static public Edge2 GetEdge12(this Triangle2 item)
        {
            return new Edge2(item.v1, item.v2);
        }

        static public Edge2 GetEdge20(this Triangle2 item)
        {
            return new Edge2(item.v2, item.v0);
        }

        static public IEnumerable<Edge2> GetEdges(this Triangle2 item)
        {
            return item.GetPoints().CloseLoop().ConvertConnections((v0, v1) => new Edge2(v0, v1));
        }
    }
}