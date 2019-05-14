using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IEnumerableExtensions_Process
    {
        static public void Process<T>(this IEnumerable<T> item, Process<T> process)
        {
            if (item != null)
            {
                foreach (T sub_item in item)
                    process(sub_item);
            }
        }
        static public void Process<T>(this IEnumerable<T> item, Process<T> process_first, Process<T> process_remaining)
        {
            if (item != null)
            {
                using (IEnumerator<T> iterator = item.GetEnumerator())
                {
                    if (iterator.MoveNext())
                    {
                        process_first(iterator.Current);

                        while (iterator.MoveNext())
                            process_remaining(iterator.Current);
                    }
                }
            }
        }

        static public bool ProcessAND<T>(this IEnumerable<T> item, TryProcess<T> process)
        {
            bool return_value = true;

            if (item != null)
            {
                foreach (T sub_item in item)
                    return_value &= process(sub_item);
            }

            return return_value;
        }

        static public bool ProcessOR<T>(this IEnumerable<T> item, TryProcess<T> process)
        {
            bool return_value = false;

            if (item != null)
            {
                foreach (T sub_item in item)
                    return_value |= process(sub_item);
            }

            return return_value;
        }

        static public int ProcessAndCount<T>(this IEnumerable<T> item, Process<T> process)
        {
            int count = 0;

            if (item != null)
            {
                foreach (T sub_item in item)
                {
                    process(sub_item);
                    count++;
                }
            }

            return count;
        }
        static public int ProcessAndCount<T>(this IEnumerable<T> item, Process<T> process_first, Process<T> process_remaining)
        {
            int count = 0;

            if (item != null)
            {
                using (IEnumerator<T> iterator = item.GetEnumerator())
                {
                    if (iterator.MoveNext())
                    {
                        process_first(iterator.Current);
                        count++;

                        while (iterator.MoveNext())
                        {
                            process_remaining(iterator.Current);
                            count++;
                        }
                    }
                }
            }

            return count;
        }

        static public void ProcessOr<T>(this IEnumerable<T> item, Process<T> process, Process if_none)
        {
            if (item.ProcessAndCount(process) <= 0)
                if_none();
        }
    }
}