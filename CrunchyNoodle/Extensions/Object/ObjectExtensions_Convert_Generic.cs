using System;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class ObjectExtensions_Convert_Generic
    {
        static public bool ConvertEX<T>(this object item, out T output)
        {
            return ObjectExtensions_Convert_Generic_Internal<T>.ConvertEX(item, out output);
        }
        static public T ConvertEX<T>(this object item)
        {
            T output;

            item.ConvertEX<T>(out output);
            return output;
        }
    }
}