using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class WeakReferenceExtensions_ICollection
    {
        static public void CullAndProcess(this ICollection<WeakReference> item, Process<WeakReference> process)
        {
            item.CullAndProcess(r => r.IsDead(), process);
        }

        static public void CullAndProcess<T>(this ICollection<WeakReference> item, Process<T> process)
        {
            item.CullAndProcess(delegate(WeakReference weak_reference) {
                T value;
                if (weak_reference.TryGet<T>(out value))
                    process(value);
            });
        }
    }
}