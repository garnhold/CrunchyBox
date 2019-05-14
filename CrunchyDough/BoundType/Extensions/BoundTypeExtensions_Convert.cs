using System;

namespace CrunchyDough
{
    static public class BoundTypeExtensions_Convert
    {
        static public T ConvertBoundType<T>(this BoundType item, T below, T above)
        {
            switch (item)
            {
                case BoundType.Below: return below;
                case BoundType.Above: return above;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}