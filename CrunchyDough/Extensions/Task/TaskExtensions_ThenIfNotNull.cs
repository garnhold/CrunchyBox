using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class TaskExtensions_ThenIfNotNull
    {
        static public async Task ThenIfNotNull<T>(this Task<T> item, Process<T> process)
        {
            await item.Then(i => i.IfNotNull(process));
        }

        static public async Task<J> ThenIfNotNull<T, J>(this Task<T> item, Operation<J, T> operation)
        {
            return await item.Then(i => i.IfNotNull(operation));
        }
        static public async Task<J> ThenIfNotNull<T, J>(this Task<T> item, Operation<J, T> operation, J if_null)
        {
            return await item.Then(i => i.IfNotNull(operation, if_null));
        }
        static public async Task<J> ThenIfNotNull<T, J>(this Task<T> item, Operation<J, T> operation, Operation<J> if_null)
        {
            return await item.Then(i => i.IfNotNull(operation, if_null));
        }

        static public async Task<J> ThenIfNotNull<T, J>(this Task<T> item, Operation<Task<J>, T> operation)
        {
            return await item.Then(i => i.IfNotNull(operation));
        }
        static public async Task<J> ThenIfNotNull<T, J>(this Task<T> item, Operation<Task<J>, T> operation, Task<J> if_null)
        {
            return await item.Then(i => i.IfNotNull(operation, if_null));
        }
        static public async Task<J> ThenIfNotNull<T, J>(this Task<T> item, Operation<Task<J>, T> operation, Operation<Task<J>> if_null)
        {
            return await item.Then(i => i.IfNotNull(operation, if_null));
        }
    }
}