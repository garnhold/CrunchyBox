using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector3Extensions_IEnumerable_Planar
    {
        static public IEnumerable<Vector2> GetPlanar(this IEnumerable<Vector3> item)
        {
            return item.Convert(v => v.GetPlanar());
        }
    }
}