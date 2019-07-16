using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [AttributeUsage(AttributeTargets.Field)]
    public class AssetFieldAttribute : Attribute
    {
        private bool should_force_non_null;

        public AssetFieldAttribute(bool non_null)
        {
            should_force_non_null = non_null;
        }

        public bool ShouldForceNonNull()
        {
            return should_force_non_null;
        }
    }
}