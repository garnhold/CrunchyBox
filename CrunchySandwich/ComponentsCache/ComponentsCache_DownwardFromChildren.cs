using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public class ComponentsCache_DownwardFromChildren<T> : ComponentsCache<T>
    {
        protected override IEnumerable<T> GetComponentsInternal(Component parent)
        {
            return parent.GetComponentsDownwardFromChildren<T>();
        }

        public ComponentsCache_DownwardFromChildren(Component p) : base(p) { }
    }
}