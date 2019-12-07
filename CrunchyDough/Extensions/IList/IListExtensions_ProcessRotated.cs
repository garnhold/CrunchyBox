using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IListExtensions_ProcessRotated
    {
        static public int ProcessSubRotated<T>(this IList<T> item, int start, int length, Process<T> process)
        {
            int i = 0;

            int pre_loop_start = start;
            int pre_loop_end = item.Count.Min(pre_loop_start + length);
            int pre_loop_length = pre_loop_end - pre_loop_start;

            for (i = pre_loop_start; i < pre_loop_end; i++)
                process(item[i]);

            int post_loop_length = length - pre_loop_length;
            if (post_loop_length > 0)
            {
                int post_loop_start = 0;
                int post_loop_end = pre_loop_start.Min(post_loop_start + post_loop_length);

                for (i = post_loop_start; i < post_loop_end; i++)
                    process(item[i]);
            }

            return i;
        }

        static public int ProcessSubSectionRotated<T>(this IList<T> item, int start, int end, Process<T> process)
        {
            return item.ProcessSubRotated(start, end - start, process);
        }
    }
}