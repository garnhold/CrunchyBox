using System;

namespace Crunchy.Dough
{
    static public class CharExtensions_Alphabet
    {
        static public int GetAlphabetIndex(this char item)
        {
            item = item.ToUpper();

            if ('A' <= item && item <= 'Z')
                return (int)(item - 'A');

            return -1;
        }
    }
}