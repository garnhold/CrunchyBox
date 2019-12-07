using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public class ComponentCacheManager : Subsystem<ComponentCacheManager>
    {
        [SerializeFieldEX]private Duration cache_lifetime;

        public Duration GetCacheLifetime()
        {
            return cache_lifetime;
        }
    }
}