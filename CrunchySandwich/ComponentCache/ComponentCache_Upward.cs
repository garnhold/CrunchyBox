using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public class ComponentCache_Upward<T> : ComponentCache<T>
    {
        protected override T GetComponentInternal(Component parent)
        {
            return parent.GetComponentUpward<T>();
        }

        public ComponentCache_Upward(Component parent) : base(parent) { }
    }
}