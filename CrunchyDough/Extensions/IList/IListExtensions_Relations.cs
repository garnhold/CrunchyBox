using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Relations
    {
        static public IEnumerable<Tuple<int, int>> GetRelationIndexs<T>(this IList<T> item, Relation<T, T> relation)
        {
            for (int i = 0; i < item.Count; i++)
            {
                T sub_item1 = item[i];

                for (int j = i + 1; j < item.Count; j++)
                {
                    T sub_item2 = item[j];

                    if (relation(sub_item1, sub_item2))
                        yield return Tuple.New(i, j);
                }
            }
        }

        static public IEnumerable<Tuple<T, T>> GetRelations<T>(this IList<T> item, Relation<T, T> relation)
        {
            for (int i = 0; i < item.Count; i++)
            {
                T sub_item1 = item[i];

                for (int j = i + 1; j < item.Count; j++)
                {
                    T sub_item2 = item[j];

                    if (relation(sub_item1, sub_item2))
                        yield return Tuple.New(sub_item1, sub_item2);
                }
            }
        }
    }
}