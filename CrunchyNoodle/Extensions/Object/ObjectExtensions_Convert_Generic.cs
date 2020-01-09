using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class ObjectExtensions_Convert_Generic
    {
        static public bool ConvertEX<T>(this object item, out T output, bool allow_null_object = false)
        {
            return ObjectExtensions_Convert_Generic_Internal<T>.ConvertEX(item, out output, allow_null_object);
        }
        static public T ConvertEX<T>(this object item)
        {
            T output;

            item.ConvertEX<T>(out output);
            return output;
        }
    }
}