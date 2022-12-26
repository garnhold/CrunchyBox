using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class TaskExtensions_Then
    {
        static public async Task<J> Then<T, J>(this Task<T> item, Operation<J, T> operation)
        {
            return operation(await item);
        }
        static public async Task Then<T>(this Task<T> item, Process<T> process)
        {
            process(await item);
        }

        static public async Task<J> Then<J>(this Task item, Operation<J> operation)
        {
            await item;
            return operation();
        }
        static public async Task Then(this Task item, Process process)
        {
            await item;
            process();
        }
    }
}