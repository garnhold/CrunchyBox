using System;
using System.Reflection;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class ObjectExtensions_Convert_Generic_Internal<T>
    {
        static public bool ConvertEX(object item, out T output, bool allow_null_object = false)
        {
            if (item != null)
            {
                if (item.Convert<T>(out output, allow_null_object))
                    return true;

                BasicMethodInvoker invoker = item.GetType().GetConversionInvoker<T>();
                if (invoker != null)
                {
                    output = (T)invoker(null, new object[] { item });
                    return true;
                }
            }

            output = default(T);
            return false;
        }
    }
}