using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class Triangle3Extensions_Edge
    {
        static public Edge3 GetEdge01(this Triangle3 item)
        {
            return new Edge3(item.v0, item.v1);
        }

        static public Edge3 GetEdge12(this Triangle3 item)
        {
            return new Edge3(item.v1, item.v2);
        }

        static public Edge3 GetEdge20(this Triangle3 item)
        {
            return new Edge3(item.v2, item.v0);
        }

        static public IEnumerable<Edge3> GetEdges(this Triangle3 item)
        {
            return item.GetPoints().CloseLoop().ConvertConnections((v0, v1) => new Edge3(v0, v1));
        }
    }
}