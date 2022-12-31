using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Quad2Extensions_Winding
    {
        static public Quad2 GetReversedWinding(this Quad2 item)
        {
            return new Quad2(item.v3, item.v2, item.v1, item.v0);
        }
    }
}