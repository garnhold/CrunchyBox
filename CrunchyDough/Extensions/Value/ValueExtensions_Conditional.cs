using System;

namespace CrunchyDough
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
    }
}