using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class ComponentCache_UpwardFromParent<T> : ComponentCache<T>
    {
        protected override IEnumerable<T> GetComponentsInternal(Component component)
        {
            return component.GetComponentsUpwardFromParent<T>();
        }

        public ComponentCache_UpwardFromParent(Component c) : base(c) { }
    }
}