using System;

namespace Crunchy.Dough
{
    static public class ValueExtensions_PseudoStack
    {
        static public void PushPopInto<T>(this T item, ref T state, Process process)
        {
            T old_state = state;

            state = item;
            process();

            state = old_state;
        }

        static public J PushPopInto<T, J>(this T item, ref T state, Operation<J> operation)
        {
            J to_return = default(J);

            item.PushPopInto(ref state, delegate() {
                to_return = operation();
            });

            return to_return;
        }
    }
}