using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class Triangle3Extensions_Fantize
    {
        static public IEnumerable<Triangle3> Fantize(this Triangle3 item, Vector3 point)
        {
            yield return new Triangle3(item.v0, item.v1, point);
            yield return new Triangle3(item.v1, item.v2, point);
            yield return new Triangle3(item.v2, item.v0, point);
        }

        static public IEnumerable<Triangle3> FantizeAtCenter(this Triangle3 item)
        {
            return item.Fantize(item.GetCenter());
        }
    }
}