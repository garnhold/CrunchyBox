using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Change
    {
        static public bool Change<T>(this IList<T> item, IEnumerable<T> values)
        {
            int index = 0;
            bool did_change = false;

            foreach (T value in values)
            {
                if (index < item.Count)
                {
                    if (item[index].NotEqualsEX(value))
                    {
                        item[index] = value;
                        did_change = true;
                    }
                }
                else
                {
                    item.Add(value);
                    did_change = true;
                }

                index++;
            }

            for (int i = item.Count - 1; i >= index; i--)
                item.RemoveAt(i);

            return did_change;
        }
    }
}