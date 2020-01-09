using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class GridExtensions_Vectorize
    {
        static public IEnumerable<List<Vector2>> Vectorize(this Grid<bool> item, int maximum_gap, float scale, Vector2 offset)
        {
            return item.TraverseEdges(maximum_gap).Convert(
                p => p.Convert(c => c.GetPosition() * scale + offset).ToList()
            );
        }
    }
}