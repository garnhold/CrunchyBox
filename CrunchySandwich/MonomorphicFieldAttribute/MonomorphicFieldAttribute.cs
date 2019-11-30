using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyRecipe;

namespace CrunchySandwich
{
    public class MonomorphicFieldAttribute : ObjectSignifyFieldAttribute
    {
        private Type target_type;

        public MonomorphicFieldAttribute(Type t)
        {
            target_type = t;
        }

        public Type GetTargetType()
        {
            return target_type;
        }
    }
}