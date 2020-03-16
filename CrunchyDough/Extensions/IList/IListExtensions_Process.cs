using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_Process
    {
        static public void ProcessSubSection<T>(this IList<T> item, int start, int end, Process<T> process)
        {
            for (int i = start; i < end; i++)
                process(item[i]);
        }

        static public void ProcessSubArea<T>(this IList<T> item, int center, int radius, Process<T> process)
        {
            item.ProcessSubSection<T>(center - radius, center + radius, process);
        }

        static public void ProcessSub<T>(this IList<T> item, int start, int length, Process<T> process)
        {
            item.ProcessSubSection<T>(start, start + length, process);
        }

        static public void ProcessOffset<T>(this IList<T> item, int start, Process<T> process)
        {
            item.ProcessSubSection<T>(start, item.Count, process);
        }

        static public void ProcessTruncate<T>(this IList<T> item, int end, Process<T> process)
        {
            item.ProcessSubSection<T>(0, end, process);
        }
    }
}