using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StringExtensions_Islands
    {
        static public IEnumerable<string> GetIslands(this string item)
        {
            if (item != null)
                return item.Split(CharExtensions_Category.WHITESPACE);

            return Empty.IEnumerable<string>();
        }
    }
}