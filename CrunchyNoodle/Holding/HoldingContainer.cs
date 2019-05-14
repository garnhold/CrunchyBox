using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;

using CrunchyDough;

namespace CrunchyNoodle
{
    public interface HoldingContainer<P> : IEnumerable
    {
        bool TryAdd(Holdable<P> to_add);
        bool Remove(Holdable<P> to_remove);

        P GetParent();
    }
}