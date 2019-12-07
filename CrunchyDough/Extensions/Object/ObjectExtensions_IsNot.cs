using System;

namespace Crunchy.Dough
{
    static public class ObjectExtensions_IsNone
    {
        static public bool IsNot<T1>(this object item)
        {
            if (item.Is<T1>() == false)
                return true;

            return false;
        }

        static public bool IsNone<T1, T2>(this object item)
        {
            if (item.IsAny<T1, T2>() == false)
                return true;

            return false;
        }

        static public bool IsNone<T1, T2, T3>(this object item)
        {
            if (item.IsAny<T1, T2, T3>() == false)
                return true;

            return false;
        }

        static public bool IsNone<T1, T2, T3, T4>(this object item)
        {
            if (item.IsAny<T1, T2, T3, T4>() == false)
                return true;

            return false;
        }
    }
}