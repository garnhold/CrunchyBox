using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class ComponentCache_UpwardFromParent<T> : ComponentCache<T>
    {
        protected override T GetComponentInternal(Component parent)
        {
            return parent.GetComponentUpwardFromParent<T>();
        }

        public ComponentCache_UpwardFromParent(Component parent) : base(parent) { }
    }
}