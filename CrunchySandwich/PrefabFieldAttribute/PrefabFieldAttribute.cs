using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [AttributeUsage(AttributeTargets.Field)]
    public class PrefabFieldAttribute : Attribute
    {
        private bool should_force_non_null;

        public PrefabFieldAttribute(bool non_null)
        {
            should_force_non_null = non_null;
        }

        public bool ShouldForceNonNull()
        {
            return should_force_non_null;
        }
    }
}