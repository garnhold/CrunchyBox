using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Crunchy.Dough
{
    static public class TypeExtensions_Treatment
    {
        static public bool CanBeTreatedAs(this Type item, Type type)
        {
            if (item != null && type != null)
            {
                if (type.IsAssignableFrom(item))
                    return true;

                if (type.IsGenericParameter)
                {
                    if (type.GetGenericParameterConstraints().AreAll(t => item.CanBeTreatedAs(t)))
                        return true;
                }
            }

            return false;
        }
        static public bool CanBeTreatedAs<T>(this Type item)
        {
            return item.CanBeTreatedAs(typeof(T));
        }

        static public bool CanHold(this Type item, Type type)
        {
            if (type.CanBeTreatedAs(item))
                return true;

            return false;
        }
        static public bool CanHold<T>(this Type item)
        {
            return item.CanHold(typeof(T));
        }

        static public bool CouldMaybeHold(this Type item, Type type)
        {
            if (item.IsRelated(type))
                return true;

            return false;
        }
        static public bool CouldMaybeHold<T>(this Type item)
        {
            return item.CouldMaybeHold(typeof(T));
        }

        static public bool CanHaveChildTypes(this Type item)
        {
            if (item.IsSealed == false && item.IsValueType == false && item.IsVoidType() == false)
                return true;

            return false;
        }
    }
}