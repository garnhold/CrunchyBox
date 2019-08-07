using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    public class ComponentCacheManager : Subsystem<ComponentCacheManager>
    {
        [SerializeFieldEX]private Duration cache_lifetime;

        public Duration GetCacheLifetime()
        {
            return cache_lifetime;
        }
    }
}