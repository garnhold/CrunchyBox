using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class ComponentsCache_WithinEntity<T> : ComponentsCache<T>
    {
        protected override IEnumerable<T> GetComponentsInternal(Component parent)
        {
            return parent.GetComponentsWithinEntity<T>();
        }

        public ComponentsCache_WithinEntity(Component p) : base(p) { }
    }
}