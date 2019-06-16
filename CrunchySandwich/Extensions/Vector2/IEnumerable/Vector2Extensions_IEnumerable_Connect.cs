using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class Vector2Extensions_IEnumerable_Connect
    {
        static public IEnumerable<LineSegment2> Connect(this IEnumerable<Vector2> item)
        {
            return item.ConvertConnections((v0, v1) => new LineSegment2(v0, v1));
        }
    }
}