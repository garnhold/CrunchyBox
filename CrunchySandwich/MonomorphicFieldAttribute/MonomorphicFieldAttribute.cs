using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;
    using Recipe;
    
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