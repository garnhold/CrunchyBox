using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class PropertyInfoExtensions_Can
    {
        static public bool CanSet(this PropertyInfo item)
        {
            if (item.GetSetMethod(true) != null)
                return true;

            return false;
        }

        static public bool CanGet(this PropertyInfo item)
        {
            if (item.GetGetMethod(true) != null)
                return true;

            return false;
        }

        static public bool CanSetAndGet(this PropertyInfo item)
        {
            if (item.CanSet() && item.CanGet())
                return true;

            return false;
        }
    }
}