using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{    
    static public class VectorF2Extensions_IEnumerable_LineSegmentF2s
    {
        static public IEnumerable<LineSegmentF2> ConvertToLineSegmentF2s(this IEnumerable<VectorF2> item)
        {
            return item.ConvertConnections((v1, v2) => new LineSegmentF2(v1, v2));
        }
    }
}