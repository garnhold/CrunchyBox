using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class StackExtensions_PushPop
    {
        static public void PushPop<T>(this Stack<T> item, T value, Process process)
        {
            item.Push(value);
                process();
            item.Pop();
        }
        static public J PushPop<T, J>(this Stack<T> item, T value, Operation<J> operation)
        {
            J to_return = default(J);

            item.PushPop(value, delegate() {
                to_return = operation();
            });

            return to_return;
        }

        static public void PushPopUsePreviousCount<T>(this Stack<T> item, T value, Process<int> process)
        {
            int count = item.Count(value);

            item.PushPop(value, delegate() {
                process(count);
            });
        }
        static public J PushPopUsePreviousCount<T, J>(this Stack<T> item, T value, Operation<J, int> operation)
        {
            int count = item.Count(value);

            return item.PushPop(value, delegate() {
                return operation(count);
            });
        }
    }
}