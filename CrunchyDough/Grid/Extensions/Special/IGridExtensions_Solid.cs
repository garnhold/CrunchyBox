using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IGridExtensions_Solid
    {
        static public IGrid<bool> ConvertToEdges(this IGrid<bool> item)
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

        static public IGrid<bool> ConvertToStrictEdges(this IGrid<bool> item)
        {
            IGrid<bool> edges = item.ConvertToEdges().ToGrid();

            return edges.ConvertWithIndexs(delegate (VectorI2 index, bool value) {
                if (value)
                {
                    if (index.GetNeighbors().Convert(p => edges.Get(p)).Count(false) >= 4)
                        return true;
                }

                return false;
            });
        }

        static public IEnumerable<IEnumerable<VectorI2>> TraverseEdges(this IGrid<bool> item, int maximum_gap)
        {
            VectorI2 point;
            IGrid<bool> edges = item.ConvertToStrictEdges().ToGrid();

            int width = edges.GetWidth();
            int height = edges.GetHeight();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
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