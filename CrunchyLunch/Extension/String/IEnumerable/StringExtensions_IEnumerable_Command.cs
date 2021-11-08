using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

namespace Crunchy.Lunch
{
    static public class StringExtensions_IEnumerable_Command
    {
        static public string MakeCommand(this IEnumerable<string> item)
        {
            return item.Convert(i => i.EscapeCommand()).Join(" ");
        }
    }
}