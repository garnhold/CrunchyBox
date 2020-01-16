using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class ICollectionExtensions_ProcessAndChain
    {
        static public ICollection<T> ProcessAndChain<T>(this ICollection<T> item, Process<T> process)
        {
            item.Process(process);

            return item;
        }
    }
}