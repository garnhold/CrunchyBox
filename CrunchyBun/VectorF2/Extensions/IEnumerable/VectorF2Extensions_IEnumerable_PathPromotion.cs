using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bun
{
    using Dough;
    
    static public class VectorF2Extensions_IEnumerable_PathPromotion
    {
        static public IEnumerable<VectorF2> SubdividePathToLength(this IEnumerable<VectorF2> item, float maximum_inter_length)
        {
            return item.SubdividePathToLength<VectorF2>(maximum_inter_length, delegate(VectorF2 v1, VectorF2 v2) {
                return v1.GetDistanceTo(v2);
            }, delegate(VectorF2 v1, VectorF2 v2, float f) {
                return v1.GetInterpolate(v2, f);
            });
        }

        static public IEnumerable<VectorF2> SubdividePathByDivisions(this IEnumerable<VectorF2> item, int divisions)
        {
            return item.SubdividePathByDivisions<VectorF2>(divisions, delegate(VectorF2 v1, VectorF2 v2, float f) {
                return v1.GetInterpolate(v2, f);
            });
        }
    }
}