using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IListExtensions_Extract_Section
    {
        static public IEnumerable<T> ExtractSubSection<T>(this IList<T> item, int start, int end)
        {
            List<T> subsection = item.SubSection(start, end).ToList();

            item.RemoveSubSection(start, end);
            return subsection;
        }

        static public IEnumerable<T> ExtractSub<T>(this IList<T> item, int start, int length)
        {
            return item.ExtractSubSection(start, start + length);
        }

        static public IEnumerable<T> ExtractBeginning<T>(this IList<T> item, int start)
        {
            return item.ExtractSubSection(start, item.Count);
        }

        static public IEnumerable<T> ExtractEnding<T>(this IList<T> item, int end)
        {
            return item.ExtractSubSection(0, end);
        }

        static public IEnumerable<T> ExtractTrim<T>(this IList<T> item, int amount)
        {
            return item.ExtractEnding(item.Count - amount);
        }
    }
}