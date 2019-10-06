using System;
using System.Reflection;

namespace CrunchyDough
{
    static public class PropertyInfoExtensions_Access
    {
        static public bool IsSetPublic(this PropertyInfo item)
        {
            if (item.GetSetMethod(true).IfNotNull(m => m.IsPublicMethod()))
                return true;

            return false;
        }

        static public bool IsGetPublic(this PropertyInfo item)
        {
            if (item.GetGetMethod(true).IfNotNull(m => m.IsPublicMethod()))
                return true;

            return false;
        }

        static public bool IsSetAndGetPublic(this PropertyInfo item)
        {
            if (item.IsSetPublic() && item.IsGetPublic())
                return true;

            return false;
        }
    }
}