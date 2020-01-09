using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_Search_Count
    {
        static public IEnumerable<T> FindFirstNonEmpty<T>(this IEnumerable<IEnumerable<T>> item)
        {
            bool has_returned = false;

            foreach(IEnumerable<T> sub_item in item)
            {
                if(has_returned == false)
                {
                    using (IEnumerator<T> iter = sub_item.GetEnumerator())
                    {
                        if (iter.MoveNext())
                        {
                            do
                            {
                                yield return iter.Current;
                            } while (iter.MoveNext());

                            has_returned = true;
                        }
                    }
                }
            }
        }

        static public IEnumerable<OUTPUT_TYPE> FindFirstNonEmpty<INPUT_TYPE, OUTPUT_TYPE>(this IEnumerable<INPUT_TYPE> item, Operation<IEnumerable<OUTPUT_TYPE>, INPUT_TYPE> operation)
        {
            return item.Convert<INPUT_TYPE, IEnumerable<OUTPUT_TYPE>>(operation)
                .FindFirstNonEmpty();
        }
    }
}