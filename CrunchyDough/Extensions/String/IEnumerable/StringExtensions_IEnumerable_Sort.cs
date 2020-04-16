using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_IEnumerable_Sort
    {
        static public IEnumerable<string> NaturalSort(this IEnumerable<string> item)
        {
            return item.NaturalSort(s => s);
        }
    }
}