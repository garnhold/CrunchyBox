using System;

namespace Crunchy.Dough
{
    static public class ObjectExtensions_Treatment
    {
        static public bool CanObjectBeTreatedAs(this object item, Type type)
        {
            if (item != null)
                return item.GetType().CanBeTreatedAs(type);

            return false;
        }

        static public bool CanObjectBeTreatedAs<T>(this object item)
        {
            return item.CanObjectBeTreatedAs(typeof(T));
        }
    }
}