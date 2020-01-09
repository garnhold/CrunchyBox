using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public class ComponentsCache_UpwardAndDownward<T> : ComponentsCache<T>
    {
        protected override IEnumerable<T> GetComponentsInternal(Component parent)
        {
            return parent.GetComponentsUpwardAndDownward<T>();
        }

        public ComponentsCache_UpwardAndDownward(Component p) : base(p) { }
    }
}