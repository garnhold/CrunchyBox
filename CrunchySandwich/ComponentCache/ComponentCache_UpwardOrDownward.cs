using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public class ComponentCache_UpwardOrDownward<T> : ComponentCache<T>
    {
        protected override T GetComponentInternal(Component parent)
        {
            return parent.GetComponentUpwardOrDownward<T>();
        }

        public ComponentCache_UpwardOrDownward(Component parent) : base(parent) { }
    }
}