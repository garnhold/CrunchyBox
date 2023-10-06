using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class Chars
    {
        static public IEnumerable<char> Range(char first, char last, bool include_end)
        {
            if (include_end)
            {
                for (char i = first; i <= last; i++)
                    yield return i;
            }
            else
            {
                for (char i = first; i < last; i++)
                    yield return i;
            }
        }
    }
}