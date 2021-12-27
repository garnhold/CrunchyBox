using System;

namespace Crunchy.Dough
{
    static public class IntegerTypeExtensions_Parse
    {
        static public object Parse(this IntegerType item, string input)
        {
            switch (item)
            {
                case IntegerType.Short: return input.ParseShort();
                case IntegerType.Int: return input.ParseInt();
                case IntegerType.Long: return input.ParseLong();
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}