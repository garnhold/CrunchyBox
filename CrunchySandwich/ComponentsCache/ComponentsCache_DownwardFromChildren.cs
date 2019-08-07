using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class ComponentsCache_DownwardFromChildren<T> : ComponentsCache<T>
    {
        protected override IEnumerable<T> GetComponentsInternal(Component parent)
        {
            return parent.GetComponentsDownwardFromChildren<T>();
        }

        public ComponentsCache_DownwardFromChildren(Component c) : base(c) { }
    }
}