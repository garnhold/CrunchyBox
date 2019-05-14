using System;

namespace CrunchyDough
{
    static public class BoolExtensions_If
    {
        static public T IfTrue<T>(this bool item, Operation<T> if_true, Operation<T> if_false)
        {
            if (item)
                return if_true();

            return if_false();
        }

        static public T IfTrue<T>(this bool item, Operation<T> if_true, T if_false)
        {
            return item.IfTrue(if_true, () => if_false);
        }

        static public T IfTrue<T>(this bool item, Operation<T> if_true)
        {
            return item.IfTrue(if_true, default(T));
        }

        static public void IfTrue(this bool item, Process if_true, Process if_false)
        {
            if (item)
                if_true();
            else
                if_false();
        }

        static public void IfTrue(this bool item, Process if_true)
        {
            item.IfTrue(if_true, () => { });
        }
    }
}