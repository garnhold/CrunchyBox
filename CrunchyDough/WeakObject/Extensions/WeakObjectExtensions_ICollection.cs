using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class WeakObjectExtensions_ICollection
    {
        static public void CullAndProcess<T>(this ICollection<T> item, Process<T> process) where T : WeakObject
        {
            item.CullAndProcess(r => r.IsDead(), process);
        }
    }
}