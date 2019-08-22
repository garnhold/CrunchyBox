﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class ComponentsCache_UpwardAndDownward<T> : ComponentsCache<T>
    {
        protected override IEnumerable<T> GetComponentsInternal(Component parent)
        {
            return parent.GetComponentsUpwardAndDownward<T>();
        }

        public ComponentsCache_UpwardAndDownward(Component c) : base(c) { }
    }
}