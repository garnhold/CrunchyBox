using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_Solid
    {
        static public IList2D<bool> ConvertToEdges(this IList2D<bool> item)
        {
            return item.ConvertWithIndexs(delegate (int x, int y, bool value) {
                if (value)
                {
                    if (item.GetNeighbors(x, y).Has(false))
                        return true;
                }

                return false;
            });
        }

        static public IList2D<bool> ConvertToStrictEdges(this IList2D<bool> item)
        {
            IList2D<bool> edges = item.ConvertToEdges().ToList2D();

            return edges.ConvertWithIndexs(delegate(int x, int y, bool value) {
                if (value)
                {
                    if (edges.GetNeighbors(x, y).Count(false) >= 4)
                        return true;
                }

                return false;
            });
        }
    }
}