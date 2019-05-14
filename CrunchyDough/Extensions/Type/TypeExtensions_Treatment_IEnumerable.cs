using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CrunchyDough
{
    static public class TypeExtensions_Treatment_IEnumerable
    {
        static public bool IsTypicalIEnumerable(this Type item)
        {
            if (item.CanBeTreatedAs<IEnumerable>() && item.IsString() == false)
                return true;

            return false;
        }
    }
}