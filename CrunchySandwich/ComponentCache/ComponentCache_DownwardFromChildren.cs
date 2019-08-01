using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class ComponentCache_DownwardFromChildren<T> : ComponentCache<T>
    {
        protected override IEnumerable<T> GetComponentsInternal(Component component)
        {
            return component.GetComponentsDownwardFromChildren<T>();
        }

        public ComponentCache_DownwardFromChildren(Component c) : base(c) { }
    }
}