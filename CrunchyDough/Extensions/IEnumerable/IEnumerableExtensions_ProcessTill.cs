using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_ProcessTill
    {
        static public bool ProcessTillComplete<T>(this IEnumerable<T> item, TryProcess<T> process)
        {
            if (item != null)
            {
                List<T> failed = new List<T>(item);

                do
                {
                    failed.RemoveAll(delegate(T sub_item) {
                        return process(sub_item);
                    });
                }
                while (failed.IsNotEmpty());

                if (failed.IsEmpty())
                    return true;
            }

            return false;
        }

        static public bool ProcessTillCompleteOrStagnated<T>(this IEnumerable<T> item, TryProcess<T> process)
        {
            if (item != null)
            {
                int old_count;
                List<T> failed = new List<T>(item);
                
                do
                {
                    old_count = failed.Count;

                    failed.RemoveAll(delegate(T sub_item) {
                        return process(sub_item);
                    });
                }
                while (failed.IsNotEmpty() && old_count != failed.Count);

                if (failed.IsEmpty())
                    return true;
            }

            return false;
        }
    }
}