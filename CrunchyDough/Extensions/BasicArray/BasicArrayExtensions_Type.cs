using System;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class BasicArrayExtensions_Type
    {
        static public Type GetElementType(this Array item)
        {
            if (item != null)
                return item.GetType().GetElementType();

            return null;
        }
    }
}
