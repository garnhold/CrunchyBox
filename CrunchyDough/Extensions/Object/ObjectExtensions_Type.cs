using System;

namespace CrunchyDough
{
    static public class ObjectExtensions_Type
    {
        static public Type GetTypeEX(this object item)
        {
            if (item != null)
                return item.GetType();

            return null;
        }

        static public bool IsObjectType(this object item, Type type)
        {
            if (item.GetTypeEX() == type)
                return true;

            return false;
        }
    }
}