using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class TypeExtensions_Generation
    {
        static public int GetTypeGeneration(this Type item)
        {
            return item.GetTypeDistance(typeof(object));
        }
    }
}