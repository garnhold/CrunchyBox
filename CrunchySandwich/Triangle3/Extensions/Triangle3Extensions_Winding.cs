using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Triangle3Extensions_Winding
    {
        static public Triangle3 GetReversedWinding(this Triangle3 item)
        {
            return new Triangle3(item.v2, item.v1, item.v0);
        }
    }
}