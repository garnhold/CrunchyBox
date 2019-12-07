using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_IEnumerable_Append
    {
        static public IEnumerable<string> AppendVisible(this IEnumerable<string> item, string to_append)
        {
            return item.AppendIf(to_append.IsVisible(), to_append);
        }

        static public IEnumerable<string> PrependVisible(this IEnumerable<string> item, string to_prepend)
        {
            return item.PrependIf(to_prepend.IsVisible(), to_prepend);
        }
    }
}