using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Noodle;
    using Bun;
    
    static public class ContactPoint2DExtensions_Penetration
    {
        static public Vector2 GetPenetration(this ContactPoint2D item)
        {
            return item.normal * item.separation;
        }
    }
}