using System;

namespace Crunchy.Dough
{
    static public class ValueExtensions_Conditional
    {
        static public J IfNotNull<T, J>(this T item, Operation<J, T> operation, Operation<J> if_null)
        {
            if (item.IsNotNull())
                return operation.Execute(item);

            return if_null.Execute();
        }

        static public J IfNotNull<T, J>(this T item, Operation<J, T> operation, J if_null)
        {
            if (item.IsNotNull())
                return operation.Execute(item);

            return if_null;
        }
        static public J IfNotNull<T, J>(this T item, Operation<J, T> operation)
        {
            return item.IfNotNull(operation, default(J));
        }

        static public void IfNotNull<T>(this T item, Process<T> process)
        {
            if (item.IsNotNull())
                process(item);
        }

        static public void IfNotNull<T>(this T item, Process<T> process, Process if_null)
        {
            if (item.IsNotNull())
                process(item);
            else
                if_null();
        }

        static public T Coalesce<T>(this T item, params T[] others)
        {
            if (item.IsNotNull())
                return item;

            foreach (T value in others)
            {
                if (value.IsNotNull())
                    return value;
            }

            return default(T);
        }
        static public T Coalesce<T>(this T item, params Operation<T>[] others)
        {
            if (item.IsNotNull())
                return item;

            foreach (Operation<T> other in others)
            {
                T value = other();

                if (value.IsNotNull())
                    return value;
            }

            return default(T);
        }
    }
}