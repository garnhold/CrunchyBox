using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector3Extensions_IEnumerable_Connect
    {
        static public IEnumerable<LineSegment3> Connect(this IEnumerable<Vector3> item)
        {
            return item.ConvertConnections((v0, v1) => new LineSegment3(v0, v1));
        }
    }
}