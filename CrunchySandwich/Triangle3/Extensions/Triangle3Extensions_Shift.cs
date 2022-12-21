using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Triangle3Extensions_Shift
    {
        static public Triangle3 GetShifted(this Triangle3 item, Vector3 amount)
        {
            return new Triangle3(
                item.v0 + amount,
                item.v1 + amount,
                item.v2 + amount
            );
        }
    }
}