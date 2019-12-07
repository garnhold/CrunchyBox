using System;
using System.Reflection;

namespace Crunchy.Dough
{
    static public class MethodInfoExtensions_Compare
    {
        static public bool IsOriginalMethod(this MethodInfo item)
        {
            if (item.IsAbstract)
                return true;

            if (item.IsVirtual == false)
                return true;

            if (item.Equals(item.GetBaseDefinition()))
                return true;

            return false;
        }
        static public bool IsOriginalMethodOf(this MethodInfo item, Type type)
        {
            if (item.IsDeclaredWithin(type) && item.IsOriginalMethod())
                return true;

            return false;
        }

        static public bool IsDerivedMethod(this MethodInfo item)
        {
            if (item.IsOriginalMethod() == false)
                return true;

            return false;
        }
    }
}