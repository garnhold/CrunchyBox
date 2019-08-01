using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class ComponentCache_Downward<T> : ComponentCache<T>
    {
        protected override IEnumerable<T> GetComponentsInternal(Component component)
        {
            return component.GetComponentsDownward<T>();
        }

        public ComponentCache_Downward(Component c) : base(c) { }
    }
}