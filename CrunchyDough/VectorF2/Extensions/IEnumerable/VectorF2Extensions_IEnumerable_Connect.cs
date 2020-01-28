using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_IEnumerable_Connect
    {
        static public IEnumerable<LineSegmentF2> Connect(this IEnumerable<VectorF2> item)
        {
            return item.ConvertConnections((v0, v1) => new LineSegmentF2(v0, v1));
        }
    }
}