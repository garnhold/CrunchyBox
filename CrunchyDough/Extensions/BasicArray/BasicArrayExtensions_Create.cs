using System;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class BasicArrayExtensions_Create
    {
        static public Array CreateInstance(this Array item, int length)
        {
            if (item != null)
                return Array.CreateInstance(item.GetElementType(), length);

            return null;
        }
    }
}
