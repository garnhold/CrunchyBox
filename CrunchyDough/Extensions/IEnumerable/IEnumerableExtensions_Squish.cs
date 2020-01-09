using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Squish
    {
        static public IEnumerable<T> Squish<T>(this IEnumerable<T> item, TryOperation<T, T, T> operation)
        {
            List<T> list = item.ToList();
            bool did_squish = false;

            do
            {
                did_squish = false;
                for (int i = 0; i < list.Count; i++)
                {
                    T sub_item1 = list[i];

                    for (int j = i + 1; j < list.Count; j++)
                    {
                        T sub_item2 = list[j];

                        T squished;
                        if (operation(sub_item1, sub_item2, out squished))
                        {
                            list[i] = squished;
                            list.RemoveAt(j);

                            did_squish = true;
                            break;
                        }
                    }
                }
            } while (did_squish);

            return list;
        }

        static public IEnumerable<T> Squish<T>(this IEnumerable<T> item, Relation<T, T> relation, Operation<T, T, T> operation)
        {
            return item.Squish(delegate(T sub_item1, T sub_item2, out T squished) {
                if (relation(sub_item1, sub_item2))
                {
                    squished = operation(sub_item1, sub_item2);
                    return true;
                }

                squished = default(T);
                return false;
            });
        } 
    }
}