using System;
using System.Reflection;

namespace Crunchy.Dough
{
    static public class MethodBaseExtensions_Declaration
    {
        static public bool IsDeclaredWithin(this MethodBase item, Type type)
        {
            if (item.DeclaringType == type)
                return true;

            return false;
        }
    }
}