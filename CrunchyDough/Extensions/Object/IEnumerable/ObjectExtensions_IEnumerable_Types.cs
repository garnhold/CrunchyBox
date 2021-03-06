using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ObjectExtensions_IEnumerable_Types
    {
        static public IEnumerable<Type> GetTypes(this IEnumerable<object> item)
        {
            return item.Convert(o => o.GetTypeEX());
        }
    }
}