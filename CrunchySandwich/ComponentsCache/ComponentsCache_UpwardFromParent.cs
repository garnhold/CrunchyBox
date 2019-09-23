﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class ComponentsCache_UpwardFromParent<T> : ComponentsCache<T>
    {
        protected override IEnumerable<T> GetComponentsInternal(Component parent)
        {
            return parent.GetComponentsUpwardFromParent<T>();
        }

        public ComponentsCache_UpwardFromParent(Component p) : base(p) { }
    }
}