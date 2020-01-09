using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public class ComponentCache_Downward<T> : ComponentCache<T>
    {
        protected override T GetComponentInternal(Component parent)
        {
            return parent.GetComponentDownward<T>();
        }

        public ComponentCache_Downward(Component parent) : base(parent) { }
    }
}