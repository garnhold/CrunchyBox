﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class ComponentCache_WithinEntity<T> : ComponentCache<T>
    {
        protected override T GetComponentInternal(Component parent)
        {
            return parent.GetComponentWithinEntity<T>();
        }

        public ComponentCache_WithinEntity(Component c) : base(c) { }
    }
}