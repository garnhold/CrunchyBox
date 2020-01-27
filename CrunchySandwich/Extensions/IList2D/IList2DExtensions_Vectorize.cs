using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class IList2DExtensions_Vectorize
    {
        static public IEnumerable<List<Vector2>> Vectorize(this IList2D<bool> item, int maximum_gap, float scale, Vector2 offset)
        {
            return item.TraverseEdges(maximum_gap).Convert(
                p => p.Convert(c => c.GetVector2() * scale + offset).ToList()
            );
        }
    }
}