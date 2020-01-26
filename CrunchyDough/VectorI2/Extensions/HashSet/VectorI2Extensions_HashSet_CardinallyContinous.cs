using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{   
    static public class VectorI2Extensions_HashSet_CardinallyContinous
    {
        static private HashSet<VectorI2> GetCardinallyContinousAreaAtInternal(HashSet<VectorI2> item, VectorI2 point, HashSet<VectorI2> area)
        {
            if (item.Has(point))
            {
                if (area.Add(point))
                {
                    GetCardinallyContinousAreaAtInternal(item, point + VectorI2.LEFT, area);
                    GetCardinallyContinousAreaAtInternal(item, point + VectorI2.RIGHT, area);
                    GetCardinallyContinousAreaAtInternal(item, point + VectorI2.DOWN, area);
                    GetCardinallyContinousAreaAtInternal(item, point + VectorI2.UP, area);
                }
            }

            return area;
        }
        static public HashSet<VectorI2> GetCardinallyContinousAreaAt(this HashSet<VectorI2> item, VectorI2 point)
        {
            return GetCardinallyContinousAreaAtInternal(item, point, new HashSet<VectorI2>());
        }

        static public IEnumerable<HashSet<VectorI2>> GetCardinallyContinousAreas(this HashSet<VectorI2> item)
        {
            HashSet<VectorI2> copy = item.ToHashSet();
            List<HashSet<VectorI2>> areas = new List<HashSet<VectorI2>>();

            while(copy.IsNotEmpty())
            {
                VectorI2 point = copy.GetFirst();
                HashSet<VectorI2> area = copy.GetCardinallyContinousAreaAt(point);

                areas.Add(area);
                copy.ExceptWith(area);
            }

            return areas;
        }
    }
}