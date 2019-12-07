using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Join
    {
        static public string Join(this IEnumerable<string> item, string seperator = "")
        {
            StringBuilder string_builder = new StringBuilder();

            item.Process(s => string_builder.Append(s), s => { string_builder.Append(seperator); string_builder.Append(s); });
            return string_builder.ToString();
        }

        static public string JoinVisible(this IEnumerable<string> item, string seperator = "")
        {
            return item.Narrow(s => s.IsVisible()).Join(seperator);
        }
    }
}