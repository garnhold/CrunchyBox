using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StringExtensions_Lines
    {
        static public int GetNumberLines(this string item)
        {
            if (item != null)
                return item.CountAny(CharExtensions_Category.NEWLINE);

            return 0;
        }

        static public IEnumerable<string> GetLines(this string item)
        {
            if(item != null)
                return item.Split(CharExtensions_Category.NEWLINE);

            return Empty.IEnumerable<string>();
        }
    }
}