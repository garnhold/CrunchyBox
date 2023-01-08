using System;

namespace Crunchy.Dough
{
    static public class StringExtensions_CoalesceBlank
    {
        static public string CoalesceBlank(this string item, Operation<string> if_blank)
        {
            if (item.IsBlank())
                return if_blank();

            return item;
        }
        static public string CoalesceBlank(this string item, string if_blank)
        {
            return item.CoalesceBlank(() => if_blank);
        }

        static public string CoalesceBlankToNull(this string item)
        {
            if (item.IsBlank())
                return null;

            return item;
        }
    }
}