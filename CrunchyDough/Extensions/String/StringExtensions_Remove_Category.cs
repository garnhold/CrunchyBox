using System;
using System.Text;
using System.Text.RegularExpressions;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Remove_Category
    {
        static public string RemoveNonPrintable(this string item)
        {
            return item.RegexRemove("[\\p{C}-[\\s]]");
        }
    }
}