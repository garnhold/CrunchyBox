using System;

namespace Crunchy.Dough
{
    static public class RealTypeExtensions_Parse
    {
        static public object Parse(this RealType item, string input)
        {
            switch (item)
            {
                case RealType.Float: return input.ParseFloat();
                case RealType.Double: return input.ParseDouble();
                case RealType.Decimal: return input.ParseDecimal();
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}