using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class ComponentCache_Upward<T> : ComponentCache<T>
    {
        protected override IEnumerable<T> GetComponentsInternal(Component component)
        {
            return component.GetComponentsUpward<T>();
        }

        public ComponentCache_Upward(Component c) : base(c) { }
    }
}