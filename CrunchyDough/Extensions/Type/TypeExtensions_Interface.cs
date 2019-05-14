using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class TypeExtensions_Interface
    {
        static public IEnumerable<Type> GetAllInterfaces(this Type item)
        {
            return item.GetInterfaces();
        }
    }
}