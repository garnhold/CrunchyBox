using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class TypeExtensions_Interface
    {
        static public IEnumerable<Type> GetAllInterfaces(this Type item)
        {
            return item.GetInterfaces();
        }
    }
}