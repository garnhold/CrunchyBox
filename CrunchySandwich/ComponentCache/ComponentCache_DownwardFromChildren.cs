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
        protected override T GetComponentInternal(Component parent)
        {
            return parent.GetComponentDownwardFromChildren<T>();
        }

        public ComponentCache_DownwardFromChildren(Component parent) : base(parent) { }
    }
}