using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class TypeExtensions_Generation
    {
        static public int GetTypeGeneration(this Type item)
        {
            return item.GetTypeDistance(typeof(object));
        }
    }
}