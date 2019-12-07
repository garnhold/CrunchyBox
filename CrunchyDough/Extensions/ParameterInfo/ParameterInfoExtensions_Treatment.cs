using System;
using System.Reflection;

namespace Crunchy.Dough
{
    static public class ParameterInfoExtensions_Treatment
    {
        static public bool CanBeTreatedAs(this ParameterInfo item, Type type)
        {
            if (item != null)
                return item.ParameterType.CanBeTreatedAs(type);

            return false;
        }
        static public bool CanBeTreatedAs<T>(this ParameterInfo item)
        {
            return item.CanBeTreatedAs(typeof(T));
        }

        static public bool CanHold(this ParameterInfo item, Type type)
        {
            if (item != null)
                return item.ParameterType.CanHold(type);

            return false;
        }
        static public bool CanHold<T>(this ParameterInfo item)
        {
            return item.CanHold(typeof(T));
        }
    }
}