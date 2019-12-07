using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    using Sandwich;
    
    public abstract class ReflectedProperty_Single : ReflectedProperty
    {
        public ReflectedProperty_Single(ReflectedObject o, Variable v) : base(o, v) { }

        public bool TryGetContents(out ReflectedObject value)
        {
            value = new ReflectedObject(GetAllContents(), GetReflectedObject());

            if (value.IsValid())
                return true;

            return false;
        }
    }
}