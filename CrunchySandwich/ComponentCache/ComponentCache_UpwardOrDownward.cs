using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class ComponentCache_UpwardOrDownward<T> : ComponentCache<T>
    {
        protected override T GetComponentInternal(Component parent)
        {
            return parent.GetComponentUpwardOrDownward<T>();
        }

        public ComponentCache_UpwardOrDownward(Component c) : base(c) { }
    }
}