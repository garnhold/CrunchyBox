using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Island_Morph
    {
        static public Tuple<int, int> FindIslandMorphOffsets<T>(this IList<T> item, IList<T> other)
        {
            return Tuple.New(
                item.FindIndexOfFirstRelation(other, (i1, i2) => i1.NotEqualsEX(i2)),
                item.GetReverse().FindIndexOfFirstRelation(other.GetReverse(), (i1, i2) => i1.NotEqualsEX(i2))
            );
        }

        static public IslandMorphInfo CalculateIslandMorph<T>(this IList<T> item, IList<T> other)
        {
            Tuple<int, int> island_offsets = item.FindIslandMorphOffsets(other);

            return new IslandMorphInfo(
                new IslandInfo(island_offsets.item1, item.Count - island_offsets.item2),

                island_offsets.item1,
                new IslandInfo(island_offsets.item1, other.Count - island_offsets.item2)
            );
        }
    }
}