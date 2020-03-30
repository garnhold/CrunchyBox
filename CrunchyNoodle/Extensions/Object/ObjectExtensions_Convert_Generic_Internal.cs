using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class ObjectExtensions_Convert_Generic_Internal<T>
    {
        static public bool ConvertEX(object item, out T output, bool allow_null_object = false)
        {
            if (item.Convert<T>(out output, allow_null_object))
                return true;

            if (item != null)
            {
                BasicConversionInvoker invoker = item.GetType().GetConversionInvoker<T>();
                if (invoker != null)
                {
                    output = (T)invoker(item);
                    return true;
                }
            }

            output = default(T);
            return false;
        }
    }
}