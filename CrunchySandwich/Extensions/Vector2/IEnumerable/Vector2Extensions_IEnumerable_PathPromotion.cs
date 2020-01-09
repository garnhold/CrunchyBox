using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class Vector2Extensions_IEnumerable_PathPromotion
    {
        static public IEnumerable<Vector2> SubdividePathToLength(this IEnumerable<Vector2> item, float maximum_inter_length)
        {
            return item.SubdividePathToLength<Vector2>(maximum_inter_length, delegate(Vector2 v1, Vector2 v2) {
                return v1.GetDistanceTo(v2);
            }, delegate(Vector2 v1, Vector2 v2, float f) {
                return v1.GetInterpolate(v2, f);
            });
        }

        static public IEnumerable<Vector2> SubdividePathByDivisions(this IEnumerable<Vector2> item, int divisions)
        {
            return item.SubdividePathByDivisions<Vector2>(divisions, delegate(Vector2 v1, Vector2 v2, float f) {
                return v1.GetInterpolate(v2, f);
            });
        }
    }
}