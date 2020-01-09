using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_ProcessWithInterleaving
    {
        static public void ProcessWithInterleaving<T>(this IEnumerable<T> item, Process<T> process, Process process_between)
        {
            if (item != null)
            {
                using (IEnumerator<T> iterator = item.GetEnumerator())
                {
                    if (iterator.MoveNext())
                    {
                        process(iterator.Current);

                        while (iterator.MoveNext())
                        {
                            process_between();
                            process(iterator.Current);
                        }
                    }
                }
            }
        }
    }
}