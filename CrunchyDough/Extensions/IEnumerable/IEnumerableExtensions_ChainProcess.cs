using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_ChainProcess
    {
        static public IEnumerable<T> ChainProcess<T>(this IEnumerable<T> item, Process<T> process)
        {
            if (item != null)
            {
                foreach (T sub_item in item)
                {
                    process(sub_item);

                    yield return sub_item;
                }
            }
        }
    }
}