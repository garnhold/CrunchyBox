using System;

namespace Crunchy.Dough
{
    static public class BoolExtensions_Convert
    {
        static public T ConvertBool<T>(this bool item, Operation<T> if_true, Operation<T> if_false)
        {
            if (item)
                return if_true();

            return if_false();
        }

        static public T ConvertBool<T>(this bool item, T if_true, T if_false)
        {
            return item.ConvertBool<T>(() => if_true, () => if_false);
        }
        static public T ConvertBool<T>(this bool item, T if_true)
        {
            return item.ConvertBool<T>(if_true, default(T));
        }
    }
}