using System;

namespace Crunchy.Dough
{
    static public class CharExtensions_Case
    {
        static public bool IsUppercase(this char item)
        {
            if (Char.IsUpper(item))
                return true;

            return false;
        }

        static public bool IsLowercase(this char item)
        {
            if (Char.IsLower(item))
                return true;

            return false;
        }

        static public char ToUpper(this char item)
        {
            return Char.ToUpper(item);
        }

        static public char ToLower(this char item)
        {
            return Char.ToLower(item);
        }

        static public char ReplaceCase(this char item, bool upper_case)
        {
            if (upper_case)
                return item.ToUpper();

            return item.ToLower();
        }
    }
}