using System;
using System.Reflection;

namespace Crunchy.Dough
{
    static public class MethodBaseExtensions_Return
    {
        static public Type GetReturnType(this MethodBase item)
        {
            MethodInfo cast;

            if (item.Convert<MethodInfo>(out cast))
                return cast.ReturnType;

            return typeof(void);
        }

        static public bool HasNoReturn(this MethodBase item)
        {
            if (item.GetReturnType().IsVoidType())
                return true;

            return false;
        }

        static public bool HasReturn(this MethodBase item)
        {
            if (item.HasNoReturn() == false)
                return true;

            return false;
        }

        static public bool CanReturnInto(this MethodBase item, Type type)
        {
            if (type.CanHold(item.GetReturnType()))
                return true;

            return false;
        }
        static public bool CanReturnInto<T>(this MethodBase item)
        {
            return item.CanReturnInto(typeof(T));
        }

        static public bool CanReturnInto(this MethodInfo item, out MethodInfo output, Type type)
        {
            if (item.IsGenericTypelessMethod())
            {
                Type[] generic_arguments = new Type[item.GetNumberGenericParameters()];

                if (item.ReturnType.FillGenericArgumentsToHold(type, generic_arguments))
                {
                    if (generic_arguments.AreAllNotNull() && item.CanGenericParametersHold(generic_arguments))
                        item = item.MakeGenericMethod(generic_arguments);
                }
            }

            output = item;
            return item.CanReturnInto(type);
        }

        static public bool CouldMaybeReturnInto(this MethodBase item, Type type)
        {
            if (type.CouldMaybeHold(item.GetReturnType()))
                return true;

            return false;
        }
        static public bool CouldMaybeReturnInto<T>(this MethodBase item)
        {
            return item.CouldMaybeReturnInto(typeof(T));
        }
    }
}