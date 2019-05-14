using System;

namespace CrunchyDough
{
    static public class ObjectExtensions_Is
    {
        static public bool Is<T1>(this object item)
        {
            return (item is T1);
        }

        static public bool IsAny<T1, T2>(this object item)
        {
            return (item is T1) || (item is T2);
        }

        static public bool IsAny<T1, T2, T3>(this object item)
        {
            return (item is T1) || (item is T2) || (item is T3);
        }

        static public bool IsAny<T1, T2, T3, T4>(this object item)
        {
            return (item is T1) || (item is T2) || (item is T3) || (item is T4);
        }
    }
}