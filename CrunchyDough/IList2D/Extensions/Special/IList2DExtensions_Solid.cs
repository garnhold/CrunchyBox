using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IList2DExtensions_Solid
    {
        static public IList2D<bool> ConvertToEdges(this IList2D<bool> item)
        {
            return item.ConvertWithIndexs(delegate (VectorI2 index, bool value) {
                if (value)
                {
                    if (index.GetNeighbors().Convert(p => item.Get(p)).Has(false))
                        return true;
                }

                return false;
            });
        }

        static public IList2D<bool> ConvertToStrictEdges(this IList2D<bool> item)
        {
            IList2D<bool> edges = item.ConvertToEdges().ToList2D();

            return edges.ConvertWithIndexs(delegate (VectorI2 index, bool value) {
                if (value)
                {
                    if (index.GetNeighbors().Convert(p => edges.Get(p)).Count(false) >= 4)
                        return true;
                }

                return false;
            });
        }

        static public IEnumerable<IEnumerable<VectorI2>> TraverseEdges(this IList2D<bool> item, int maximum_gap)
        {
            VectorI2 point;
            IList2D<bool> edges = item.ConvertToStrictEdges().ToList2D();

            for (int y = 0; y < edges.GetHeight(); y++)
            {
                for (int x = 0; x < edges.GetWidth(); x++)
                {
                    point = new VectorI2(x, y);

                    if (edges.Get(point))
                    {
                        List<VectorI2> points = new List<VectorI2>();

                        do
                        {
                            edges.SetDropped(point, false);
                            points.Add(point);
                        }
                        while (point.GetRadiating(maximum_gap).TryFindFirst(p => edges.Get(p), out point));

                        if (points.Count >= 3)
                            yield return points;
                    }
                }
            }
        }
    }
}