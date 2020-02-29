using System;

namespace Crunchy.Noodle
{
    using Dough;
    
    static public class VariableExtensions_GetContents
    {
        static public T GetContents<T>(this Variable item, object target)
        {
            return item.GetContents(target).Convert<T>();
        }

        static public object GetOrCreateContents(this Variable item, object target, Operation<object> operation)
        {
            object current_contents = item.GetContents(target);

            if (current_contents == null)
            {
                current_contents = operation();
                item.SetContents(target, current_contents);
            }

            return current_contents;
        }
        static public T GetOrCreateContents<T>(this Variable item, object target, Operation<T> operation)
        {
            return item.GetOrCreateContents(target, (Operation<object>)(() => operation())).Convert<T>();
        }
    }
}