using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Triangle2Extensions_Winding
    {
        static public Triangle2 GetReversedWinding(this Triangle2 item)
        {
            return new Triangle2(item.v2, item.v1, item.v0);
        }
    }
}