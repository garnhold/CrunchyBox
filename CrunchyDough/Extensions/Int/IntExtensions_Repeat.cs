using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class IntExtensions_Repeat
    {
        static public void RepeatProcess(this int item, Process process)
        {
            for (int i = 0; i < item; i++)
                process();
        }

        static public IEnumerable<T> RepeatOperation<T>(this int item, Operation<T> operation)
        {
            for (int i = 0; i < item; i++)
                yield return operation();
        }

        static public IEnumerable<T> RepeatOperationWithIndex<T>(this int item, Operation<T, int> operation)
        {
            for (int i = 0; i < item; i++)
                yield return operation(i);
        }
    }
}